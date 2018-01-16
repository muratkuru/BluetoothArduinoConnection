using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BluetoothArduinoConnection
{
    public partial class MainForm : Form
    {
        private readonly CustomBluetoothService bluetoothService;

        private BackgroundWorker scanWorker;
        private BackgroundWorker connectionWorker;
        private BluetoothConnectionResult serviceResult;

        public MainForm()
        {
            InitializeComponent();

            bluetoothService = new CustomBluetoothService();

            scanWorker = new BackgroundWorker();
            scanWorker.DoWork += ScanWorker_DoWork;
            scanWorker.RunWorkerCompleted += ScanWorker_RunWorkerCompleted;

            connectionWorker = new BackgroundWorker();
            connectionWorker.DoWork += ConnectionWorker_DoWork;
            connectionWorker.RunWorkerCompleted += ConnectionWorker_RunWorkerCompleted;

            led1Button.Tag = 10; // arduino pin 10
            led2Button.Tag = 11; // arduino pin 11
        }

        private void DisabledAllButtons()
        {
            scanButton.Enabled = false;
            connectButton.Enabled = false;
            disconnectButton.Enabled = false;
            led1Button.Enabled = false;
            led2Button.Enabled = false;
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            DisabledAllButtons();

            scanWorker.RunWorkerAsync();
        }

        private void ScanWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bluetoothService.ScanDevices();
        }

        private void ScanWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var devices = bluetoothService.Devices;

            devicesListBox.DataSource = devices;
            devicesListBox.DisplayMember = "DeviceName";
            devicesListBox.ValueMember = "DeviceAddress";

            scanButton.Enabled = true;
            connectButton.Enabled = devices.Length > 0;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            DisabledAllButtons();

            connectionWorker.RunWorkerAsync();
        }

        private void ConnectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            object address = null;

            devicesListBox.Invoke((Action)(() =>
            {
                if (devicesListBox.SelectedIndex > -1)
                {
                    address = devicesListBox.SelectedValue;
                    e.Result = devicesListBox.Text;
                }
                else
                    MessageBox.Show("Select a device!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }));

            serviceResult = bluetoothService.Connect(address);
        }

        private void ConnectionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (serviceResult != null)
            {
                if (serviceResult.IsSuccess)
                {
                    MessageBox.Show(string.Format("Connected to {0}.", e.Result), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    led1Button.Enabled = true;
                    led2Button.Enabled = true;
                    disconnectButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show(serviceResult.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                throw new NullReferenceException("The serviceResult can not be null.");
            }

            scanButton.Enabled = true;
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            bluetoothService.Disconnect();

            DisabledAllButtons();

            scanButton.Enabled = true;
            connectButton.Enabled = true;
        }

        private void SendData_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            byte data = Convert.ToByte(button.Tag);

            bluetoothService.SendData(data);
        }
    }
}
