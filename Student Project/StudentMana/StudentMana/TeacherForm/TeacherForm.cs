using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMana
{
    public partial class TeacherForm : Form
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
        public TeacherForm()
        {
            InitializeComponent();
            /*thiết lập kiểu viền của form thành không, loại bỏ viền mặc định.*/
            this.FormBorderStyle = FormBorderStyle.None;
            /*0, 0: Tọa độ của góc trên bên trái của hình chữ nhật.
            Width, Height: Tọa độ của góc dưới bên phải của hình chữ nhật, được đặt bằng chiều rộng và chiều cao của form.
            20, 20: Chiều rộng và chiều cao của hình elip được sử dụng để tạo các góc bo tròn.*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        /*Setting Drop down profile User*/
        bool expand = false;
        private void UserProfileTimer_Tick_1(object sender, EventArgs e)
        {
            if (expand == false)
            {
                dropdownContainer.Height += 500;
                if (dropdownContainer.Height >= dropdownContainer.MaximumSize.Height)
                {
                    UserProfileTimer.Stop();
                    expand = true;
                }

            }
            else
            {
                dropdownContainer.Height -= 500;
                if (dropdownContainer.Height >= dropdownContainer.MinimumSize.Height)
                {
                    UserProfileTimer.Stop();
                    expand = false;
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserProfileTimer.Start();
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            TeacherPanel_content.Controls.Add(childForm);
            TeacherPanel_content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }  
        private void guna2Button20_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_Home());
        }
        private void guna2Button17_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_profile());

        }   
        private void guna2Button18_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_course());
        }
        private void guna2Button16_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_documents());
        }
        private void guna2Button19_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_setting());

        }  
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
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
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TeacherPanel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
