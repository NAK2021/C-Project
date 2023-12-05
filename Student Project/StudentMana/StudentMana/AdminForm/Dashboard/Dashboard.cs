using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMana
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            AdminForm_D_Student db = new AdminForm_D_Student();
            db.TopLevel = false;
           // if (AdminMenuScreen.Controls.Count > 0)
           //     AdminMenuScreen.Controls.Clear();
           // AdminMenuScreen.Controls.Add(db);
            db.BringToFront();
            db.Show();
        }

        private void LectureBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClassesBtn_Click(object sender, EventArgs e)
        {

        }

        private void SheetBtn_Click(object sender, EventArgs e)
        {

        }

        private void BlockedBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminMBtn_Click(object sender, EventArgs e)
        {

        }

        private void TermsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
