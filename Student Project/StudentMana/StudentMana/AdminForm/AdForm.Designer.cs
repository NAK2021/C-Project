using System.Drawing;
using System.Reflection.Emit;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StudentMana
{
    partial class AdForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdForm));
            this.header = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.downbtn = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AdminButton = new Guna.UI2.WinForms.Guna2Button();
            this.PageButton = new Guna.UI2.WinForms.Guna2Button();
            this.UserButton = new Guna.UI2.WinForms.Guna2Button();
            this.SystemButton = new Guna.UI2.WinForms.Guna2Button();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adssadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelChild = new Guna.UI2.WinForms.Guna2Panel();
            this.TermsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ClassesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AdminMBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BlockedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SheetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LectureBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StudentBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Data2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Data3 = new System.Windows.Forms.Label();
            this.Board1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Data1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timetxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SideBar.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.PanelChild.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.Board1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.guna2TextBox2);
            this.header.Controls.Add(this.downbtn);
            this.header.Controls.Add(this.guna2PictureBox1);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.guna2PictureBox2);
            this.header.Controls.Add(this.PanelMenu);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1276, 70);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_down);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_move);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.AutoRoundedCorners = true;
            this.guna2TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.BorderRadius = 22;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.IconRight = global::StudentMana.Properties.Resources.icons8_search_50;
            this.guna2TextBox2.Location = new System.Drawing.Point(429, 12);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox2.PlaceholderText = "Search....";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(369, 46);
            this.guna2TextBox2.TabIndex = 12;
            // 
            // downbtn
            // 
            this.downbtn.BackgroundImage = global::StudentMana.Properties.Resources.down;
            this.downbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downbtn.Location = new System.Drawing.Point(1157, 23);
            this.downbtn.Margin = new System.Windows.Forms.Padding(2);
            this.downbtn.Name = "downbtn";
            this.downbtn.Size = new System.Drawing.Size(15, 19);
            this.downbtn.TabIndex = 1;
            this.downbtn.Tag = "downbtn";
            this.downbtn.UseVisualStyleBackColor = true;
            this.downbtn.Click += new System.EventHandler(this.downbtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::StudentMana.Properties.Resources.icons8_user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1042, 11);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 44);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1093, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Tag = "NameUser";
            this.label1.Text = "Admin";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::StudentMana.Properties.Resources._367360339_1118737012843888_6418303228561789279_n;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 2);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(190, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelMenu.Location = new System.Drawing.Point(195, 12);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(221, 444);
            this.PanelMenu.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SideBar.Controls.Add(this.ExitBtn);
            this.SideBar.Controls.Add(this.MinimizeBtn);
            this.SideBar.Controls.Add(this.AdminButton);
            this.SideBar.Controls.Add(this.PageButton);
            this.SideBar.Controls.Add(this.UserButton);
            this.SideBar.Controls.Add(this.SystemButton);
            this.SideBar.Controls.Add(this.HomeButton);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SideBar.Location = new System.Drawing.Point(0, 70);
            this.SideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(116, 660);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBar_Paint);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BorderRadius = 10;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitBtn.Location = new System.Drawing.Point(62, 554);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(46, 45);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Tag = "Exit";
            this.ExitBtn.UseTransparentBackground = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BorderRadius = 10;
            this.MinimizeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Image = global::StudentMana.Properties.Resources.icons8_minimize_24;
            this.MinimizeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.MinimizeBtn.Location = new System.Drawing.Point(3, 554);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(41, 45);
            this.MinimizeBtn.TabIndex = 0;
            this.MinimizeBtn.Tag = "Minimize";
            this.MinimizeBtn.UseTransparentBackground = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click_1);
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.Transparent;
            this.AdminButton.BorderColor = System.Drawing.Color.Transparent;
            this.AdminButton.BorderRadius = 20;
            this.AdminButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Image = ((System.Drawing.Image)(resources.GetObject("AdminButton.Image")));
            this.AdminButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AdminButton.Location = new System.Drawing.Point(26, 393);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(56, 51);
            this.AdminButton.TabIndex = 0;
            this.AdminButton.UseTransparentBackground = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // PageButton
            // 
            this.PageButton.BackColor = System.Drawing.Color.Transparent;
            this.PageButton.BorderColor = System.Drawing.Color.Transparent;
            this.PageButton.BorderRadius = 20;
            this.PageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PageButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PageButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PageButton.ForeColor = System.Drawing.Color.White;
            this.PageButton.Image = ((System.Drawing.Image)(resources.GetObject("PageButton.Image")));
            this.PageButton.ImageSize = new System.Drawing.Size(30, 30);
            this.PageButton.Location = new System.Drawing.Point(26, 312);
            this.PageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PageButton.Name = "PageButton";
            this.PageButton.Size = new System.Drawing.Size(56, 48);
            this.PageButton.TabIndex = 0;
            this.PageButton.UseTransparentBackground = true;
            this.PageButton.Click += new System.EventHandler(this.PageButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.BackColor = System.Drawing.Color.Transparent;
            this.UserButton.BorderColor = System.Drawing.Color.Transparent;
            this.UserButton.BorderRadius = 20;
            this.UserButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserButton.ForeColor = System.Drawing.Color.White;
            this.UserButton.Image = ((System.Drawing.Image)(resources.GetObject("UserButton.Image")));
            this.UserButton.ImageSize = new System.Drawing.Size(30, 30);
            this.UserButton.Location = new System.Drawing.Point(26, 233);
            this.UserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(56, 51);
            this.UserButton.TabIndex = 0;
            this.UserButton.UseTransparentBackground = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // SystemButton
            // 
            this.SystemButton.BackColor = System.Drawing.Color.Transparent;
            this.SystemButton.BorderColor = System.Drawing.Color.Transparent;
            this.SystemButton.BorderRadius = 20;
            this.SystemButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SystemButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SystemButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SystemButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SystemButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SystemButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SystemButton.ForeColor = System.Drawing.Color.White;
            this.SystemButton.Image = ((System.Drawing.Image)(resources.GetObject("SystemButton.Image")));
            this.SystemButton.ImageSize = new System.Drawing.Size(36, 30);
            this.SystemButton.Location = new System.Drawing.Point(26, 155);
            this.SystemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(56, 48);
            this.SystemButton.TabIndex = 0;
            this.SystemButton.UseTransparentBackground = true;
            this.SystemButton.Click += new System.EventHandler(this.SystemButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Animated = true;
            this.HomeButton.AutoRoundedCorners = true;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderRadius = 24;
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::StudentMana.Properties.Resources.icons8_home_503;
            this.HomeButton.ImageSize = new System.Drawing.Size(30, 30);
            this.HomeButton.Location = new System.Drawing.Point(26, 65);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(56, 51);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.UseTransparentBackground = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click_1);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.adssadToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // adssadToolStripMenuItem
            // 
            this.adssadToolStripMenuItem.Name = "adssadToolStripMenuItem";
            this.adssadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adssadToolStripMenuItem.Text = "adssad";
            // 
            // PanelChild
            // 
            this.PanelChild.Controls.Add(this.TermsBtn);
            this.PanelChild.Controls.Add(this.ClassesBtn);
            this.PanelChild.Controls.Add(this.AdminMBtn);
            this.PanelChild.Controls.Add(this.BlockedBtn);
            this.PanelChild.Controls.Add(this.SheetBtn);
            this.PanelChild.Controls.Add(this.LectureBtn);
            this.PanelChild.Controls.Add(this.StudentBtn);
            this.PanelChild.Controls.Add(this.guna2Button7);
            this.PanelChild.Controls.Add(this.comboBox1);
            this.PanelChild.Controls.Add(this.guna2Panel1);
            this.PanelChild.Controls.Add(this.guna2Panel4);
            this.PanelChild.Controls.Add(this.Board1);
            this.PanelChild.Controls.Add(this.panel1);
            this.PanelChild.Controls.Add(this.pictureBox1);
            this.PanelChild.Controls.Add(this.label5);
            this.PanelChild.Location = new System.Drawing.Point(113, 70);
            this.PanelChild.Margin = new System.Windows.Forms.Padding(2);
            this.PanelChild.Name = "PanelChild";
            this.PanelChild.Size = new System.Drawing.Size(1183, 659);
            this.PanelChild.TabIndex = 11;
            this.PanelChild.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminMenuScreen_Paint);
            // 
            // TermsBtn
            // 
            this.TermsBtn.Animated = true;
            this.TermsBtn.BackColor = System.Drawing.Color.Transparent;
            this.TermsBtn.BorderColor = System.Drawing.Color.Transparent;
            this.TermsBtn.BorderRadius = 20;
            this.TermsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TermsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TermsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TermsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TermsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TermsBtn.FillColor = System.Drawing.Color.White;
            this.TermsBtn.Font = new System.Drawing.Font("Nunito", 18F);
            this.TermsBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TermsBtn.Image = ((System.Drawing.Image)(resources.GetObject("TermsBtn.Image")));
            this.TermsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TermsBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.TermsBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TermsBtn.Location = new System.Drawing.Point(659, 583);
            this.TermsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TermsBtn.Name = "TermsBtn";
            this.TermsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TermsBtn.Size = new System.Drawing.Size(201, 53);
            this.TermsBtn.TabIndex = 38;
            this.TermsBtn.Text = "Terms";
            this.TermsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TermsBtn.TextOffset = new System.Drawing.Point(-20, 0);
            this.TermsBtn.UseTransparentBackground = true;
            this.TermsBtn.Click += new System.EventHandler(this.TermsBtn_Click);
            // 
            // ClassesBtn
            // 
            this.ClassesBtn.Animated = true;
            this.ClassesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClassesBtn.BorderColor = System.Drawing.Color.Transparent;
            this.ClassesBtn.BorderRadius = 20;
            this.ClassesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClassesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClassesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClassesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClassesBtn.FillColor = System.Drawing.Color.White;
            this.ClassesBtn.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClassesBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClassesBtn.Image")));
            this.ClassesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClassesBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.ClassesBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ClassesBtn.Location = new System.Drawing.Point(885, 400);
            this.ClassesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClassesBtn.Size = new System.Drawing.Size(212, 53);
            this.ClassesBtn.TabIndex = 37;
            this.ClassesBtn.Text = "Classes";
            this.ClassesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ClassesBtn.TextOffset = new System.Drawing.Point(-20, 0);
            this.ClassesBtn.UseTransparentBackground = true;
            this.ClassesBtn.Click += new System.EventHandler(this.ClassesBtn_Click);
            // 
            // AdminMBtn
            // 
            this.AdminMBtn.Animated = true;
            this.AdminMBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminMBtn.BorderColor = System.Drawing.Color.Transparent;
            this.AdminMBtn.BorderRadius = 20;
            this.AdminMBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminMBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminMBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminMBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminMBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminMBtn.FillColor = System.Drawing.Color.White;
            this.AdminMBtn.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminMBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AdminMBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminMBtn.Image")));
            this.AdminMBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminMBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.AdminMBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AdminMBtn.Location = new System.Drawing.Point(894, 497);
            this.AdminMBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminMBtn.Name = "AdminMBtn";
            this.AdminMBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminMBtn.Size = new System.Drawing.Size(203, 53);
            this.AdminMBtn.TabIndex = 36;
            this.AdminMBtn.Text = "Admin";
            this.AdminMBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AdminMBtn.TextOffset = new System.Drawing.Point(-20, 0);
            this.AdminMBtn.UseTransparentBackground = true;
            this.AdminMBtn.Click += new System.EventHandler(this.AdminMBtn_Click);
            // 
            // BlockedBtn
            // 
            this.BlockedBtn.Animated = true;
            this.BlockedBtn.BackColor = System.Drawing.Color.Transparent;
            this.BlockedBtn.BorderColor = System.Drawing.Color.Transparent;
            this.BlockedBtn.BorderRadius = 20;
            this.BlockedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlockedBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BlockedBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BlockedBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BlockedBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BlockedBtn.FillColor = System.Drawing.Color.White;
            this.BlockedBtn.Font = new System.Drawing.Font("Nunito", 19.8F);
            this.BlockedBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BlockedBtn.Image = ((System.Drawing.Image)(resources.GetObject("BlockedBtn.Image")));
            this.BlockedBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BlockedBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.BlockedBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BlockedBtn.Location = new System.Drawing.Point(657, 497);
            this.BlockedBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlockedBtn.Name = "BlockedBtn";
            this.BlockedBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BlockedBtn.Size = new System.Drawing.Size(203, 53);
            this.BlockedBtn.TabIndex = 35;
            this.BlockedBtn.Text = "Blocked";
            this.BlockedBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BlockedBtn.TextOffset = new System.Drawing.Point(-10, 0);
            this.BlockedBtn.UseTransparentBackground = true;
            this.BlockedBtn.Click += new System.EventHandler(this.BlockedBtn_Click);
            // 
            // SheetBtn
            // 
            this.SheetBtn.Animated = true;
            this.SheetBtn.BackColor = System.Drawing.Color.Transparent;
            this.SheetBtn.BorderColor = System.Drawing.Color.Transparent;
            this.SheetBtn.BorderRadius = 20;
            this.SheetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SheetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SheetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SheetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SheetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SheetBtn.FillColor = System.Drawing.Color.White;
            this.SheetBtn.Font = new System.Drawing.Font("Nunito", 19.8F);
            this.SheetBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SheetBtn.Image = ((System.Drawing.Image)(resources.GetObject("SheetBtn.Image")));
            this.SheetBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SheetBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.SheetBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SheetBtn.Location = new System.Drawing.Point(415, 497);
            this.SheetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SheetBtn.Name = "SheetBtn";
            this.SheetBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SheetBtn.Size = new System.Drawing.Size(203, 53);
            this.SheetBtn.TabIndex = 34;
            this.SheetBtn.Text = "Sheet";
            this.SheetBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SheetBtn.TextOffset = new System.Drawing.Point(-25, 0);
            this.SheetBtn.UseTransparentBackground = true;
            this.SheetBtn.Click += new System.EventHandler(this.SheetBtn_Click);
            // 
            // LectureBtn
            // 
            this.LectureBtn.Animated = true;
            this.LectureBtn.BackColor = System.Drawing.Color.Transparent;
            this.LectureBtn.BorderColor = System.Drawing.Color.Transparent;
            this.LectureBtn.BorderRadius = 20;
            this.LectureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LectureBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LectureBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LectureBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LectureBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LectureBtn.FillColor = System.Drawing.Color.White;
            this.LectureBtn.Font = new System.Drawing.Font("Nunito", 19.8F);
            this.LectureBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LectureBtn.Image = ((System.Drawing.Image)(resources.GetObject("LectureBtn.Image")));
            this.LectureBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LectureBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.LectureBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LectureBtn.Location = new System.Drawing.Point(657, 400);
            this.LectureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LectureBtn.Name = "LectureBtn";
            this.LectureBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LectureBtn.Size = new System.Drawing.Size(203, 53);
            this.LectureBtn.TabIndex = 33;
            this.LectureBtn.Text = "Lecture";
            this.LectureBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.LectureBtn.TextOffset = new System.Drawing.Point(-11, 0);
            this.LectureBtn.UseTransparentBackground = true;
            this.LectureBtn.Click += new System.EventHandler(this.LectureBtn_Click);
            // 
            // StudentBtn
            // 
            this.StudentBtn.Animated = true;
            this.StudentBtn.BackColor = System.Drawing.Color.Transparent;
            this.StudentBtn.BorderColor = System.Drawing.Color.Transparent;
            this.StudentBtn.BorderRadius = 20;
            this.StudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StudentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StudentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StudentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StudentBtn.FillColor = System.Drawing.Color.White;
            this.StudentBtn.Font = new System.Drawing.Font("Nunito", 19.8F);
            this.StudentBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StudentBtn.Image = ((System.Drawing.Image)(resources.GetObject("StudentBtn.Image")));
            this.StudentBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StudentBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.StudentBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StudentBtn.Location = new System.Drawing.Point(415, 400);
            this.StudentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentBtn.Size = new System.Drawing.Size(203, 53);
            this.StudentBtn.TabIndex = 32;
            this.StudentBtn.Text = "Student";
            this.StudentBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StudentBtn.TextOffset = new System.Drawing.Point(-10, 0);
            this.StudentBtn.UseTransparentBackground = true;
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.Animated = true;
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button7.Font = new System.Drawing.Font("Nunito Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button7.Location = new System.Drawing.Point(959, 42);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(80, 40);
            this.guna2Button7.TabIndex = 31;
            this.guna2Button7.Text = "Reload";
            this.guna2Button7.UseTransparentBackground = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Nunito", 18F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(712, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 41);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = " Chọn ngành";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox4);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.Data2);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(929, 137);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(203, 186);
            this.guna2Panel1.TabIndex = 29;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Nunito Medium", 24F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(18, 96);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(141, 46);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.Text = "Available";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(18, 8);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(45, 44);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 2;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Nunito Medium", 24F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(18, 56);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(111, 46);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Lecture";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Data2
            // 
            this.Data2.AutoSize = true;
            this.Data2.BackColor = System.Drawing.Color.Transparent;
            this.Data2.Font = new System.Drawing.Font("Nunito ExtraBold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Data2.Location = new System.Drawing.Point(130, 134);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(57, 44);
            this.Data2.TabIndex = 3;
            this.Data2.Tag = "DataNumber";
            this.Data2.Text = "20";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 50;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.guna2PictureBox5);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel4.Controls.Add(this.Data3);
            this.guna2Panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel4.Location = new System.Drawing.Point(657, 137);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(224, 186);
            this.guna2Panel4.TabIndex = 28;
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(23, 8);
            this.guna2PictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(56, 59);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 2;
            this.guna2PictureBox5.TabStop = false;
            this.guna2PictureBox5.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Nunito Medium", 24F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(55, 80);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(114, 46);
            this.guna2HtmlLabel5.TabIndex = 3;
            this.guna2HtmlLabel5.Text = "Classes";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Data3
            // 
            this.Data3.AutoSize = true;
            this.Data3.BackColor = System.Drawing.Color.Transparent;
            this.Data3.Font = new System.Drawing.Font("Nunito ExtraBold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Data3.Location = new System.Drawing.Point(148, 136);
            this.Data3.Name = "Data3";
            this.Data3.Size = new System.Drawing.Size(57, 44);
            this.Data3.TabIndex = 3;
            this.Data3.Tag = "DataNumber";
            this.Data3.Text = "10";
            // 
            // Board1
            // 
            this.Board1.BackColor = System.Drawing.Color.Transparent;
            this.Board1.BorderColor = System.Drawing.Color.Transparent;
            this.Board1.BorderRadius = 50;
            this.Board1.BorderThickness = 1;
            this.Board1.Controls.Add(this.guna2HtmlLabel2);
            this.Board1.Controls.Add(this.guna2HtmlLabel1);
            this.Board1.Controls.Add(this.guna2PictureBox3);
            this.Board1.Controls.Add(this.Data1);
            this.Board1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Board1.CustomBorderColor = System.Drawing.Color.White;
            this.Board1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Board1.Location = new System.Drawing.Point(400, 137);
            this.Board1.Margin = new System.Windows.Forms.Padding(2);
            this.Board1.Name = "Board1";
            this.Board1.Size = new System.Drawing.Size(226, 186);
            this.Board1.TabIndex = 26;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Nunito Medium", 24F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 96);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(141, 46);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Available";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Nunito Medium", 24F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 56);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(117, 46);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Student \n";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(15, 8);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(45, 44);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // Data1
            // 
            this.Data1.AutoSize = true;
            this.Data1.BackColor = System.Drawing.Color.Transparent;
            this.Data1.Font = new System.Drawing.Font("Nunito", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data1.Location = new System.Drawing.Point(142, 145);
            this.Data1.Name = "Data1";
            this.Data1.Size = new System.Drawing.Size(71, 33);
            this.Data1.TabIndex = 3;
            this.Data1.Tag = "DataNumber";
            this.Data1.Text = "1000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.timetxt);
            this.panel1.Location = new System.Drawing.Point(74, 400);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 69);
            this.panel1.TabIndex = 25;
            // 
            // timetxt
            // 
            this.timetxt.AutoSize = true;
            this.timetxt.BackColor = System.Drawing.Color.RoyalBlue;
            this.timetxt.Font = new System.Drawing.Font("Nunito SemiBold", 22.2F, System.Drawing.FontStyle.Bold);
            this.timetxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timetxt.Location = new System.Drawing.Point(58, 13);
            this.timetxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(86, 41);
            this.timetxt.TabIndex = 5;
            this.timetxt.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StudentMana.Properties.Resources._403406882_313853028202794_1798676272926479777_n3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 275);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nunito Light", 36F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 66);
            this.label5.TabIndex = 21;
            this.label5.Tag = "";
            this.label5.Text = "DASHBOARD";
            // 
            // AdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 730);
            this.Controls.Add(this.PanelChild);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.PanelChild.ResumeLayout(false);
            this.PanelChild.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.Board1.ResumeLayout(false);
            this.Board1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel header;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private Guna.UI2.WinForms.Guna2Button SystemButton;
        private Guna.UI2.WinForms.Guna2Button UserButton;
        private Guna.UI2.WinForms.Guna2Button PageButton;
        private Guna.UI2.WinForms.Guna2Button AdminButton;
        private Guna.UI2.WinForms.Guna2Button MinimizeBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Panel SideBar;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem adssadToolStripMenuItem;
        private System.Windows.Forms.Button downbtn;
        private Guna.UI2.WinForms.Guna2Panel PanelChild;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label5;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timetxt;
        private Guna.UI2.WinForms.Guna2Panel Board1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label Data1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.Label Data3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Label Data2;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button StudentBtn;
        private Guna.UI2.WinForms.Guna2Button LectureBtn;
        private Guna.UI2.WinForms.Guna2Button SheetBtn;
        private Guna.UI2.WinForms.Guna2Button BlockedBtn;
        private Guna.UI2.WinForms.Guna2Button AdminMBtn;
        private Guna.UI2.WinForms.Guna2Button ClassesBtn;
        private Guna.UI2.WinForms.Guna2Button TermsBtn;
    }
}