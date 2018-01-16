using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;

namespace BluetoothArduinoConnection
{
    class CustomBluetoothService
    {
        private BluetoothClient bluetoothClient;

        public CustomBluetoothService()
        {
            bluetoothClient = new BluetoothClient();
        }

        public BluetoothDeviceInfo[] Devices { get; set; }

        public void ScanDevices()
        {
            Disconnect();

            Devices = bluetoothClient.DiscoverDevices();
        }

        public BluetoothConnectionResult Connect(object address)
        {
            var result = new BluetoothConnectionResult();

            try
            {
                if (address is BluetoothAddress bluetoothAddress)
                {
                    var endPoint = new BluetoothEndPoint(bluetoothAddress, BluetoothService.SerialPort);
                    bluetoothClient.Connect(endPoint);

                    result.IsSuccess = true;
                }
                else
                {
                    throw new Exception("The address should be a BluetoothAddress.");
                }
            }
            catch(Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

        public void Disconnect()
        {
            if (bluetoothClient != null)
            {
                if (bluetoothClient.Connected)
                {
                    bluetoothClient.Close();
                    bluetoothClient.Dispose();

                    bluetoothClient = new BluetoothClient();
                }
            }
        }

        public void SendData(byte value)
        {
            try
            {
                var stream = bluetoothClient.GetStream();
                stream.WriteByte(value);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    class BluetoothConnectionResult
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}
