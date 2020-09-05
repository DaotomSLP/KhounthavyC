using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;



namespace KhounthavyV2
{
    class CameraCapture
    {
        private void StartCamera(PictureBox monitor, ComboBox cobCaptureDevice){
            FilterInfoCollection captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in captureDevice ){
                cobCaptureDevice.Items.Add(device.Name);
            } 

            cobCaptureDevice.SelectedIndex = 0;

            VideoCaptureDevice videoSource = new VideoCaptureDevice
                (
                    captureDevice[cobCaptureDevice.SelectedIndex].MonikerString
                );

            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);

        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs){
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone(); 

        }

        private void CaptureImage(PictureBox pictureBox2){
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }
    }
}
