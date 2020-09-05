using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace KhounthavyV2
{
    public partial class CameraFrm : Form
    {
        VideoCaptureDevice videoSource;

        public PictureBox returnPictureBox { get; set; }

        public CameraFrm()
        {
            InitializeComponent();
        }

        private void StartCamera()
        {
            FilterInfoCollection captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

             videoSource = new VideoCaptureDevice
                (
                    captureDevice[0].MonikerString 
                );

            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CameraFrm_Load(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        public void btnOk_Click(object sender, EventArgs e)
        {
            AddPawnFrm addPawnFrm = new AddPawnFrm();
            addPawnFrm.PicImg.Image = (Bitmap)pictureBox2.Image.Clone();

            returnPictureBox = pictureBox2;

            
            videoSource.Stop();
            this.Close();
        }
    }
}
