using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProjcet
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
       
        private void ModalEffect_timer_Tick(object sender, EventArgs e)
        {
            if(Opacity >= 1)
            {
                ModalEffect_timer.Stop();

            }else
            {
                Opacity += .02;
            }
            int y = Form1.parentY += 3;
            this.Location = new Point(Form1.parentX + 220,y);
            if( y >= i)
            {
                ModalEffect_timer.Stop();
            }
        }
        int i;
        private void SignupForm_Load(object sender, EventArgs e)
        {
            i = Form1.parentY + 150;
            this.Location = new Point(Form1.parentX + 160, Form1.parentY + 150);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
