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
    public partial class AdForm : Form
    {


        bool isPanelMenuOn = true;

        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,     // x-coordinate of upper-left corner
                 int nTopRect,      // y-coordinate of upper-left corner
                 int nRightRect,    // x-coordinate of lower-right corner
                 int nBottomRect,   // y-coordinate of lower-right corner
                 int nWidthEllipse, // height of ellipse
                 int nHeightEllipse // width of ellipse
             );

        public AdForm()
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
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChild.Controls.Add(childForm);
            PanelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }  
        //Default panel
         private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
         private void SystemButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_System());

        } 
        private void UserButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_User());
        }  
        private void PageButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_Page());
        }  
        private void AdminButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_Admin());

        }      
        private void StudentBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_D_Student());
        }    
        private void LectureBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_D_Lecture());
        }  
        private void ClassesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_D_Classes());
        }
        private void SheetBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_D_Sheet());
        } 
        private void BlockedBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_D_Blocked());

        }
        private void AdminMBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminForm_D_Admin());

        } 
        private void TermsBtn_Click(object sender, EventArgs e)
        {
            //Chua co sheet o day nha

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
        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void MinimizeBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    
        private void AdminMenuScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
        private void downbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (isPanelMenuOn) 
            {
                
                f2.TopLevel = false;
                if (PanelMenu.Controls.Count > 0)
                    PanelMenu.Controls.Clear();
                PanelMenu.Controls.Add(f2);
                f2.BringToFront();
                f2.Show();
                isPanelMenuOn = false;
            }
            else
            {
                f2.Close();
            }
            
        }
    }
}