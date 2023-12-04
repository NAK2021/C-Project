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
    public partial class StudentForm : Form
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
        public StudentForm()
        {
            InitializeComponent();
            /*thiết lập kiểu viền của form thành không, loại bỏ viền mặc định.*/
            this.FormBorderStyle = FormBorderStyle.None;
            /*0, 0: Tọa độ của góc trên bên trái của hình chữ nhật.
            Width, Height: Tọa độ của góc dưới bên phải của hình chữ nhật, được đặt bằng chiều rộng và chiều cao của form.
            20, 20: Chiều rộng và chiều cao của hình elip được sử dụng để tạo các góc bo tròn.*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag =childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /*Setting Drop down profile User*/
        bool expand = false;
         private void UserProfileTimer_Tick(object sender, EventArgs e)
        {
            if(expand == false)
            {
                dropdownContainer.Height += 500;
                if(dropdownContainer.Height >= dropdownContainer.MaximumSize.Height)
                {
                    UserProfileTimer.Stop();
                    expand = true;
                }

            }
            else
            {
                dropdownContainer.Height -= 500;
                if(dropdownContainer.Height >= dropdownContainer.MinimumSize.Height)
                {
                    UserProfileTimer.Stop();
                    expand = false ;
                }
            }
        }  
        private void guna2Button6_Click(object sender, EventArgs e)
        {
          UserProfileTimer.Start();
        }  

        /*Close and Minimize window form*/
        // Close window
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Minimize window
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

            /*Panel list*/
        // Default panel  
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
          if(currentFormChild != null)
            {
                currentFormChild.Close();   
            }
            
        }
        // Home Panel
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_HomeButton());
        }
        //Profile panel
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_StudentProfile());
        }
        // Course panel
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_CourseButton());
        }
        // Fee panel
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_StudentFee());
        }
        // Setting panel
        private void SystemButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_Setting());
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
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }
      
       private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {


        }

        private void guna2PictureBox9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
