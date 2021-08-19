using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using DirectShowLib;

namespace CameraCapture
{
    public partial class MainMenu : Form
    {
        private VideoCapture captureDevice = null;
        private DsDevice[] devices = null;
        private int cameraId = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for(int i = 0; i < devices.Length; i++)
            {
                ListOfDevices.Items.Add(devices[i].Name);
            }
        }


        private void ViewButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if(devices.Length == 0)
                {
                    throw new Exception("No available devices");
                }

                if(ListOfDevices.SelectedItem == null)
                {
                    throw new Exception("Need to choose a device");
                }

                if (captureDevice != null)
                {
                    captureDevice.Start();
                }
                else
                {
                    captureDevice = new VideoCapture(cameraId);
                    captureDevice.ImageGrabbed += CaptureDevice_ImageGrabbed;
                    captureDevice.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaptureDevice_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat mat = new Mat();
                if (captureDevice != null)
                {
                    captureDevice.Retrieve(mat);
                    Screen.Image = mat.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal).ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(captureDevice != null)
                {
                    captureDevice.Pause();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (captureDevice != null)
                {
                    captureDevice.Pause();
                    captureDevice.Dispose();
                    captureDevice = null;
                    Screen.Image.Dispose();
                    Screen.Image = null;
                    cameraId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListOfDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cameraId = ListOfDevices.SelectedIndex;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ScreenShotButton_Click(object sender, EventArgs e)
        {
            try
            {
                Mat mat = new Mat();
                if (captureDevice != null)
                {
                    captureDevice.Retrieve(mat);
                    var screenShotForm = new ScreenShotForm(mat.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal));
                    screenShotForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
