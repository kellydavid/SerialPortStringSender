using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortStringSender
{
    public class SerialConnection
    {
        public SerialPort serialPort;

        public delegate void SerialPortStateChangedDelegate();
        public event SerialPortStateChangedDelegate SerialPortStateChangedEvent;

        public SerialConnection() {
            initialiseConnection();
        }

        private void initialiseConnection(){
            serialPort = new SerialPort();
            serialPort.BaudRate = 115200;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            serialPort.NewLine = "\r\n\r";
        }

        public void setComPort(string portName) {
            serialPort.PortName = portName;
        }

        public void openConnection(){
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                    SerialPortStateChangedEvent();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Could not open connection.");
                }
            }
        }

        public void closeConnection() {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                SerialPortStateChangedEvent();
            }
        }

        public void sendString(string sendStr) {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.DiscardOutBuffer();
                    serialPort.WriteLine(sendStr);
                }
                catch(Exception e){
                    MessageBox.Show(e.Message, "Error sending string.");
                }
            }
            else {
                MessageBox.Show("Serial Port is not open");
            }
        }
    }
}
