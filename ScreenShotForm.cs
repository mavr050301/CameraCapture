using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using System.IO;

namespace CameraCapture
{
    public partial class ScreenShotForm : Form
    {
        private Image<Bgr, byte> image = null;
        private string fileName = String.Empty;
        public ScreenShotForm(Image<Bgr,byte> image)
        {
            this.image = image;
            InitializeComponent();
        }

        private void ScreenShotForm_Load(object sender, EventArgs e)
        {
            fileName = $"CC_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}_{DateTime.Now.Hour}_{DateTime.Now.Minute}_{DateTime.Now.Second}.jpeg";
            ScreenShotScreen.Image = image.ToBitmap();
        }

        private void SaveScreenShotButton_Click(object sender, EventArgs e)
        {
            try
            {
                ScreenShotScreen.Image.Save(fileName, ImageFormat.Jpeg);
                if (File.Exists(fileName))
                {
                    Close();
                }
                else
                {
                    throw new Exception("Cannot save a screenshot");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
