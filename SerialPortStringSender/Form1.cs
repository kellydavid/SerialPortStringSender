using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortStringSender
{
    public partial class SerialPortStringSender : Form
    {

        public SerialConnection serialConnection;

        public SerialPortStringSender()
        {
            InitializeComponent();
            serialConnection = new SerialConnection();
            serialConnection.SerialPortStateChangedEvent += serialPortStateChanged;
            closeButton.Enabled = false;
            sendStringTextBox.Multiline = true;
            sendStringTextBox.AcceptsTab = true;
            sendStringTextBox.AcceptsReturn = false;
            this.AcceptButton = sendButton;
        }

        private void serialPortStateChanged() {
            Action<bool> del = updateGuiControlSerialCon;
            this.BeginInvoke(del, serialConnection.serialPort.IsOpen);
        }

        private void updateGuiControlSerialCon(bool isOpen) {
            if (isOpen)
            {
                refreshButton.Enabled = false;
                comPortComboBox.Enabled = false;
                openConnectionButton.Enabled = false;
                closeButton.Enabled = true;
            }
            else {
                refreshButton.Enabled = true;
                comPortComboBox.Enabled = true;
                openConnectionButton.Enabled = true;
                closeButton.Enabled = false;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialConnection.sendString(sendStringTextBox.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            comPortComboBox.Items.Clear();
            string[] portNames = SerialPort.GetPortNames();
            foreach (string str in portNames)
                comPortComboBox.Items.Add(str);
        }

        private void openConnectionButton_Click(object sender, EventArgs e)
        {
            serialConnection.openConnection();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            serialConnection.closeConnection();
        }

        private void comPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string portName = (string)comPortComboBox.SelectedItem;
            if (portName != "")
                serialConnection.setComPort(portName);
        }
    }
}
