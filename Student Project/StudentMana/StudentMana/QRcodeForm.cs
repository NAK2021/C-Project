using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using Guna.UI2.WinForms;
using ZXing;
using ZXing.QrCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentMana
{
    public partial class QRcodeForm : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public QRcodeForm()
        {
            InitializeComponent();
        }


        private void QRcodeForm_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in CaptureDevice)
            
                ComboBox1.Items.Add(filterInfo.Name);
            ComboBox1.SelectedIndex = 0;  

        }   

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[ComboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            //when click start button then the timer will run to check QR code that fit with "TranKienPhong" or not
            //timer1.Enabled = true;
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            PicQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)PicQR.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "TranKienPhong")
                {
                    timer1.Stop();
                    FormQr form = new FormQr();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //when click start button then the timer will run to check QR code that fit with "TranKienPhong" or not
            timer1.Enabled = true;

        }
        //When the login success then turn off the camera
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }
    }
}
