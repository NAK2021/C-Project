using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMana
{
    public partial class Form1 : Form
    {
        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;

        /*Set border line for winForm*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        /*Đoạn này khai báo một phương thức static extern cho hàm CreateRoundRectRgn từ thư viện GDI32.dll. 
         * Hàm này được sử dụng để tạo một vùng hình chữ nhật có góc bo tròn.
         */
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,     // x-coordinate of upper-left corner
                 int nTopRect,      // y-coordinate of upper-left corner
                 int nRightRect,    // x-coordinate of lower-right corner
                 int nBottomRect,   // y-coordinate of lower-right corner
                 int nWidthEllipse, // height of ellipse
                 int nHeightEllipse // width of ellipse
             );

        public Form1()
        {
            InitializeComponent();
            /*thiết lập kiểu viền của form thành không, loại bỏ viền mặc định.*/
            this.FormBorderStyle = FormBorderStyle.None;
            /*0, 0: Tọa độ của góc trên bên trái của hình chữ nhật.
            Width, Height: Tọa độ của góc dưới bên phải của hình chữ nhật, được đặt bằng chiều rộng và chiều cao của form.
            20, 20: Chiều rộng và chiều cao của hình elip được sử dụng để tạo các góc bo tròn.*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            PasswordText.MouseHover += new EventHandler(PasswordText_MouseHover);
            PasswordText.MouseLeave += new EventHandler(PasswordText_MouseLeave);

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /* Warning caplock ON/OFF*/
        ToolTip toolTip1 = new ToolTip();
        void PasswordText_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(PasswordText);
        }
        void PasswordText_MouseHover(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {

                toolTip1.ToolTipTitle = "Caps Lock Is On";
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.IsBalloon = true;
                toolTip1.SetToolTip(PasswordText, "Having Caps Lock on may cause you to enter your password incorrectly.\n\nYou should press Caps Lock to turn it off before entering your password.");
                toolTip1.Show("Having Caps Lock on may cause you to enter your password incorrectly.\n\nYou should press Caps Lock to turn it off before entering your password.", PasswordText, 5, PasswordText.Height - 5);
            }
            if (Control.IsKeyLocked(Keys.NumLock))
            {

                toolTip1.ToolTipTitle = "Num Lock Is On";
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.IsBalloon = true;
                toolTip1.SetToolTip(PasswordText, "Having Num Lock on may cause you to enter your password incorrectly.\n\nYou should press Num Lock to turn it off before entering your password.");
                toolTip1.Show("Having Num Lock on may cause you to enter your password incorrectly.\n\nYou should press Num Lock to turn it off before entering your password.", PasswordText, 5, PasswordText.Height - 5);
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    
        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            PictureBox cur_pass = (PictureBox)sender;
            switch (cur_pass.Name)
            {
                case ("EyeOpenButton"):
                    cur_pass.Enabled = false;
                    cur_pass.Visible = false;
                    //cur_pass.Location = new Point(373, 298);

                    PasswordText.PasswordChar = '*';
                    EyeCloseButton.Enabled = true;
                    EyeCloseButton.Visible = true;
                    //Close_eye.Location = new Point(342, 298);
                    break;
                case ("EyeCloseButton"):
                    cur_pass.Enabled = false;
                    cur_pass.Visible = false;
                    //cur_pass.Location = new Point(373, 298);
                    PasswordText.PasswordChar = default;
                    EyeOpenButton.Enabled = true;
                    EyeOpenButton.Visible = true;
                    //Open_eye.Location = new Point(342, 298);
                    break;
                default: break;
            }
        }
        /*Close Form*/
        private void ButtonClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*Minimize Form*/
        private void ButtonMinimze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        /*Cusor Moving Form*/
        private void Form_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void Form_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

     
        /*Login in multiple form*/
        private void LogInbutton_Click(object sender, EventArgs e)
        {
            /* if ((UserIDTextBox.Text.Equals("trankienphong")) && (PasswordText.Text.Equals("2003")))
             {
                 Form form2 = new StudentForm();
                 form2.ShowDialog();
             }
             else
             {
                 MessageBox.Show("Your Login ID or Password is not corret");

             }*/
            if (UserIDTextBox.Text != null && PasswordText.Text != null)
            {
                string username = UserIDTextBox.Text;
                string password = PasswordText.Text;

                switch (username)
                {
                    case "trankienphong":
                        if (password.Equals("2003"))
                        {
                            Form form2 = new StudentForm();
                            form2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Your Login ID or Password is not correct");
                        }
                        break;

                    case "giangvien":
                        if (password.Equals("giangvien"))
                        {
                            Form form3 = new TeacherForm();
                            form3.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Your Login ID or Password is not correct");
                        }
                        break;

                    case "giaovu":
                        if (password.Equals("giaovu"))
                        {
                            Form form4 = new GiaoVuForm();
                            form4.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Your Login ID or Password is not correct");
                        }
                        break;

                    case "admin":
                        if (password.Equals("admin"))
                        {
                            Form form5 = new AdForm();
                            form5.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Your Login ID or Password is not correct");
                        }
                        break;

                    default:
                        MessageBox.Show("User not found");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter both Login ID and Password");
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QrScannerButton_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (QRcodeForm modal = new QRcodeForm())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .5d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                QRcodeForm m = new QRcodeForm();
                m.ShowDialog();

                modalBackground.Dispose();

            }
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        /*Form2*/
        private void ForgotpassButton_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using (SignupForm modal = new SignupForm())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .5d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                SignupForm m = new SignupForm();
                m.ShowDialog();

                modalBackground.Dispose();

            }
        }
    }
}
