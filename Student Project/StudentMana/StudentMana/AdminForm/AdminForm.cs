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
    public partial class AdminForm : Form
    {
        bool isPanelMenuOn = true;

        public Point mouseLocation; 
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

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timetxt.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.TopLevel = false;
            if (AdminMenuScreen.Controls.Count > 0)
            AdminMenuScreen.Controls.Clear();
            AdminMenuScreen.Controls.Add(db);
            db.BringToFront();
            db.Show();

        }

        private void MinimizeBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void SystemButton_Click(object sender, EventArgs e)
        {
            AdminForm_System db = new AdminForm_System();
            db.TopLevel = false;
            if (AdminMenuScreen.Controls.Count > 0)
                AdminMenuScreen.Controls.Clear();
            AdminMenuScreen.Controls.Add(db);
            db.BringToFront();
            db.Show();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            AdminForm_User db = new AdminForm_User();
            db.TopLevel = false;
            if (AdminMenuScreen.Controls.Count > 0)
                AdminMenuScreen.Controls.Clear();
            AdminMenuScreen.Controls.Add(db);
            db.BringToFront();
            db.Show();
        }

        private void PageButton_Click(object sender, EventArgs e)
        {
            AdminForm_Page db = new AdminForm_Page();
            db.TopLevel = false;
            if (AdminMenuScreen.Controls.Count > 0)
                AdminMenuScreen.Controls.Clear();
            AdminMenuScreen.Controls.Add(db);
            db.BringToFront();
            db.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm_Admin db = new AdminForm_Admin();
            db.TopLevel = false;
            if (AdminMenuScreen.Controls.Count > 0)
                AdminMenuScreen.Controls.Clear();
            AdminMenuScreen.Controls.Add(db);
            db.BringToFront();
            db.Show();
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