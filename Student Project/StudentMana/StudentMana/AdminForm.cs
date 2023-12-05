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
            timetxt.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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