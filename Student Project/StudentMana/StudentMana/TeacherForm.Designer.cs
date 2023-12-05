namespace StudentMana
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dropdownContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Dropdown_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChild = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button19 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button20 = new Guna.UI2.WinForms.Guna2Button();
            this.TeacherPanel_content = new Guna.UI2.WinForms.Guna2Panel();
            this.UserProfileTimer = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.dropdownContainer.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.panelChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.dropdownContainer);
            this.header.Controls.Add(this.Dropdown_Button);
            this.header.Controls.Add(this.guna2PictureBox2);
            this.header.Controls.Add(this.label5);
            this.header.Controls.Add(this.guna2PictureBox3);
            this.header.Controls.Add(this.guna2TextBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1727, 102);
            this.header.TabIndex = 19;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_down);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_move);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::StudentMana.Properties.Resources._367360339_1118737012843888_6418303228561789279_n;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(4, 4);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(237, 92);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1427, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 28);
            this.label5.TabIndex = 3;
            this.label5.Tag = "NameUser";
            this.label5.Text = "Kien Phong Professor";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::StudentMana.Properties.Resources.icons8_user;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(1337, 9);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(60, 68);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.BorderRadius = 27;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconRight = global::StudentMana.Properties.Resources.icons8_search_50;
            this.guna2TextBox1.Location = new System.Drawing.Point(608, 15);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox1.PlaceholderText = "Search....";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(492, 57);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // dropdownContainer
            // 
            this.dropdownContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dropdownContainer.BackColor = System.Drawing.Color.Transparent;
            this.dropdownContainer.Controls.Add(this.guna2Panel2);
            this.dropdownContainer.Location = new System.Drawing.Point(1135, 102);
            this.dropdownContainer.Margin = new System.Windows.Forms.Padding(4);
            this.dropdownContainer.Name = "dropdownContainer";
            this.dropdownContainer.Size = new System.Drawing.Size(228, 42);
            this.dropdownContainer.TabIndex = 17;
            this.dropdownContainer.UseTransparentBackground = true;
            // 
            // Dropdown_Button
            // 
            this.Dropdown_Button.Animated = true;
            this.Dropdown_Button.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Dropdown_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dropdown_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dropdown_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dropdown_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dropdown_Button.FillColor = System.Drawing.Color.White;
            this.Dropdown_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dropdown_Button.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Button.Image = global::StudentMana.Properties.Resources.icons8_down_24__1_;
            this.Dropdown_Button.Location = new System.Drawing.Point(1167, 56);
            this.Dropdown_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Dropdown_Button.Name = "Dropdown_Button";
            this.Dropdown_Button.Size = new System.Drawing.Size(33, 21);
            this.Dropdown_Button.TabIndex = 5;
            this.Dropdown_Button.UseTransparentBackground = true;
            this.Dropdown_Button.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 50);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(228, 361);
            this.guna2Panel2.TabIndex = 16;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::StudentMana.Properties.Resources._403604064_1426511601284473_762316867722643294_n;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(8, 4);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(215, 65);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito Black", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Acitvity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito Black", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Acitvity";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Panel4.Controls.Add(this.panelChild);
            this.guna2Panel4.Controls.Add(this.MinimizeButton);
            this.guna2Panel4.Controls.Add(this.CloseButton);
            this.guna2Panel4.Controls.Add(this.guna2Button16);
            this.guna2Panel4.Controls.Add(this.guna2Button17);
            this.guna2Panel4.Controls.Add(this.guna2Button18);
            this.guna2Panel4.Controls.Add(this.guna2Button19);
            this.guna2Panel4.Controls.Add(this.guna2Button20);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 102);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(153, 874);
            this.guna2Panel4.TabIndex = 20;
            // 
            // panelChild
            // 
            this.panelChild.AutoScroll = true;
            this.panelChild.Controls.Add(this.guna2Panel5);
            this.panelChild.Location = new System.Drawing.Point(151, 0);
            this.panelChild.Margin = new System.Windows.Forms.Padding(4);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1576, 891);
            this.panelChild.TabIndex = 21;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.AutoScroll = true;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(1323, 715);
            this.guna2Panel5.TabIndex = 21;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Animated = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BorderRadius = 20;
            this.MinimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.MinimizeButton.Image = global::StudentMana.Properties.Resources.icons8_minimize_24;
            this.MinimizeButton.Location = new System.Drawing.Point(9, 805);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(55, 46);
            this.MinimizeButton.TabIndex = 18;
            this.MinimizeButton.UseTransparentBackground = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Animated = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderRadius = 20;
            this.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.CloseButton.Image = global::StudentMana.Properties.Resources.icons8_logout_50;
            this.CloseButton.Location = new System.Drawing.Point(72, 805);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(64, 46);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.UseTransparentBackground = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // guna2Button16
            // 
            this.guna2Button16.Animated = true;
            this.guna2Button16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BorderRadius = 20;
            this.guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.Image = global::StudentMana.Properties.Resources.icons8_document_64;
            this.guna2Button16.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button16.Location = new System.Drawing.Point(39, 345);
            this.guna2Button16.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(75, 59);
            this.guna2Button16.TabIndex = 4;
            this.guna2Button16.UseTransparentBackground = true;
            this.guna2Button16.Click += new System.EventHandler(this.guna2Button16_Click);
            // 
            // guna2Button17
            // 
            this.guna2Button17.Animated = true;
            this.guna2Button17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button17.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button17.BorderRadius = 20;
            this.guna2Button17.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button17.ForeColor = System.Drawing.Color.White;
            this.guna2Button17.Image = global::StudentMana.Properties.Resources.icon51;
            this.guna2Button17.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button17.Location = new System.Drawing.Point(39, 169);
            this.guna2Button17.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(75, 59);
            this.guna2Button17.TabIndex = 4;
            this.guna2Button17.UseTransparentBackground = true;
            this.guna2Button17.Click += new System.EventHandler(this.guna2Button17_Click);
            // 
            // guna2Button18
            // 
            this.guna2Button18.Animated = true;
            this.guna2Button18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderRadius = 20;
            this.guna2Button18.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button18.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button18.ForeColor = System.Drawing.Color.White;
            this.guna2Button18.Image = global::StudentMana.Properties.Resources.icons8_course_50;
            this.guna2Button18.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button18.Location = new System.Drawing.Point(39, 254);
            this.guna2Button18.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(75, 59);
            this.guna2Button18.TabIndex = 3;
            this.guna2Button18.UseTransparentBackground = true;
            this.guna2Button18.Click += new System.EventHandler(this.guna2Button18_Click);
            // 
            // guna2Button19
            // 
            this.guna2Button19.Animated = true;
            this.guna2Button19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button19.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button19.BorderRadius = 20;
            this.guna2Button19.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button19.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button19.ForeColor = System.Drawing.Color.White;
            this.guna2Button19.Image = global::StudentMana.Properties.Resources.icons8_system_50;
            this.guna2Button19.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button19.Location = new System.Drawing.Point(39, 457);
            this.guna2Button19.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button19.Name = "guna2Button19";
            this.guna2Button19.Size = new System.Drawing.Size(75, 59);
            this.guna2Button19.TabIndex = 2;
            this.guna2Button19.UseTransparentBackground = true;
            this.guna2Button19.Click += new System.EventHandler(this.guna2Button19_Click);
            // 
            // guna2Button20
            // 
            this.guna2Button20.Animated = true;
            this.guna2Button20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button20.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button20.BorderRadius = 20;
            this.guna2Button20.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button20.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button20.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button20.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button20.ForeColor = System.Drawing.Color.White;
            this.guna2Button20.Image = global::StudentMana.Properties.Resources.icons8_home_501;
            this.guna2Button20.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button20.Location = new System.Drawing.Point(39, 81);
            this.guna2Button20.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button20.Name = "guna2Button20";
            this.guna2Button20.Size = new System.Drawing.Size(75, 59);
            this.guna2Button20.TabIndex = 0;
            this.guna2Button20.UseTransparentBackground = true;
            this.guna2Button20.Click += new System.EventHandler(this.guna2Button20_Click);
            // 
            // TeacherPanel_content
            // 
            this.TeacherPanel_content.AutoScroll = true;
            this.TeacherPanel_content.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TeacherPanel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeacherPanel_content.Location = new System.Drawing.Point(153, 102);
            this.TeacherPanel_content.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherPanel_content.Name = "TeacherPanel_content";
            this.TeacherPanel_content.Size = new System.Drawing.Size(1574, 874);
            this.TeacherPanel_content.TabIndex = 21;
            // 
            // UserProfileTimer
            // 
            this.UserProfileTimer.Tick += new System.EventHandler(this.UserProfileTimer_Tick_1);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 976);
            this.Controls.Add(this.TeacherPanel_content);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.dropdownContainer.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel header;
        private Guna.UI2.WinForms.Guna2Panel dropdownContainer;
        private Guna.UI2.WinForms.Guna2Button Dropdown_Button;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button MinimizeButton;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button guna2Button19;
        private Guna.UI2.WinForms.Guna2Button guna2Button20;
        private Guna.UI2.WinForms.Guna2Panel panelChild;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel TeacherPanel_content;
        private System.Windows.Forms.Timer UserProfileTimer;
    }
}