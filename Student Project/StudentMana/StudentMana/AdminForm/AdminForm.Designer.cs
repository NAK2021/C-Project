using System.Drawing;
using System.Reflection.Emit;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StudentMana
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.header = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.downbtn = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.AdminMenuScreen = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SideBar.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.AdminMenuScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.downbtn);
            this.header.Controls.Add(this.guna2PictureBox2);
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1728, 68);
            this.header.TabIndex = 0;
            // 
            // downbtn
            // 
            this.downbtn.BackgroundImage = global::StudentMana.Properties.Resources.down;
            this.downbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downbtn.Location = new System.Drawing.Point(1537, 26);
            this.downbtn.Name = "downbtn";
            this.downbtn.Size = new System.Drawing.Size(20, 23);
            this.downbtn.TabIndex = 1;
            this.downbtn.Tag = "downbtn";
            this.downbtn.UseVisualStyleBackColor = true;
            this.downbtn.Click += new System.EventHandler(this.downbtn_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::StudentMana.Properties.Resources._367360339_1118737012843888_6418303228561789279_n;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(4, 3);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(237, 62);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1457, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Tag = "NameUser";
            this.label1.Text = "Admin";
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
            this.SideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.SideBar.Location = new System.Drawing.Point(0, 67);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(120, 714);
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
            this.ExitBtn.Location = new System.Drawing.Point(66, 658);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 44);
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
            this.MinimizeBtn.Location = new System.Drawing.Point(4, 658);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(45, 44);
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
            this.AdminButton.Location = new System.Drawing.Point(20, 320);
            this.AdminButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(75, 52);
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
            this.PageButton.Location = new System.Drawing.Point(20, 256);
            this.PageButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PageButton.Name = "PageButton";
            this.PageButton.Size = new System.Drawing.Size(75, 52);
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
            this.UserButton.Location = new System.Drawing.Point(20, 192);
            this.UserButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(75, 52);
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
            this.SystemButton.Location = new System.Drawing.Point(20, 128);
            this.SystemButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(75, 52);
            this.SystemButton.TabIndex = 0;
            this.SystemButton.UseTransparentBackground = true;
            this.SystemButton.Click += new System.EventHandler(this.SystemButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderRadius = 20;
            this.HomeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageSize = new System.Drawing.Size(30, 30);
            this.HomeButton.Location = new System.Drawing.Point(20, 64);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 52);
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(125, 52);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // adssadToolStripMenuItem
            // 
            this.adssadToolStripMenuItem.Name = "adssadToolStripMenuItem";
            this.adssadToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.adssadToolStripMenuItem.Text = "adssad";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Transparent;
            this.PanelMenu.Location = new System.Drawing.Point(1253, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(314, 546);
            this.PanelMenu.TabIndex = 10;
            // 
            // AdminMenuScreen
            // 
            this.AdminMenuScreen.Controls.Add(this.PanelMenu);
            this.AdminMenuScreen.Location = new System.Drawing.Point(119, 67);
            this.AdminMenuScreen.Name = "AdminMenuScreen";
            this.AdminMenuScreen.Size = new System.Drawing.Size(1609, 714);
            this.AdminMenuScreen.TabIndex = 11;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2TextBox1.BorderRadius = 12;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconRight = global::StudentMana.Properties.Resources.icons8_search_50;
            this.guna2TextBox1.Location = new System.Drawing.Point(625, 16);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.PlaceholderText = "Search...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(492, 36);
            this.guna2TextBox1.TabIndex = 4;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::StudentMana.Properties.Resources.icons8_user;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1389, 3);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 54);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1727, 781);
            this.Controls.Add(this.AdminMenuScreen);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.AdminMenuScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel header;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
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
        private Guna.UI2.WinForms.Guna2Panel AdminMenuScreen;
    }
}