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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.header = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dropdownContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dropdown_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timetxt = new System.Windows.Forms.Label();
            this.Board1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Data1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Data3 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Data2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.header.SuspendLayout();
            this.dropdownContainer.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.panelChild.SuspendLayout();
            this.TeacherPanel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Board1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
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
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1295, 83);
            this.header.TabIndex = 19;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_down);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_move);
            // 
            // dropdownContainer
            // 
            this.dropdownContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dropdownContainer.BackColor = System.Drawing.Color.Transparent;
            this.dropdownContainer.Controls.Add(this.guna2Panel2);
            this.dropdownContainer.Location = new System.Drawing.Point(851, 83);
            this.dropdownContainer.Name = "dropdownContainer";
            this.dropdownContainer.Size = new System.Drawing.Size(171, 34);
            this.dropdownContainer.TabIndex = 17;
            this.dropdownContainer.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 41);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(171, 293);
            this.guna2Panel2.TabIndex = 16;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::StudentMana.Properties.Resources._403604064_1426511601284473_762316867722643294_n;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(161, 53);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito Black", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Acitvity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito Black", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Acitvity";
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
            this.Dropdown_Button.Location = new System.Drawing.Point(875, 46);
            this.Dropdown_Button.Name = "Dropdown_Button";
            this.Dropdown_Button.Size = new System.Drawing.Size(25, 17);
            this.Dropdown_Button.TabIndex = 5;
            this.Dropdown_Button.UseTransparentBackground = true;
            this.Dropdown_Button.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::StudentMana.Properties.Resources._367360339_1118737012843888_6418303228561789279_n;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(178, 75);
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
            this.label5.Location = new System.Drawing.Point(1070, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 22);
            this.label5.TabIndex = 3;
            this.label5.Tag = "NameUser";
            this.label5.Text = "Kien Phong Professor";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::StudentMana.Properties.Resources.icons8_user;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(1003, 7);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(45, 55);
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
            this.guna2TextBox1.BorderRadius = 22;
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
            this.guna2TextBox1.Location = new System.Drawing.Point(456, 12);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.guna2TextBox1.PlaceholderText = "Search....";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(369, 46);
            this.guna2TextBox1.TabIndex = 0;
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
            this.guna2Panel4.Location = new System.Drawing.Point(0, 83);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(115, 710);
            this.guna2Panel4.TabIndex = 20;
            // 
            // panelChild
            // 
            this.panelChild.AutoScroll = true;
            this.panelChild.Controls.Add(this.guna2Panel5);
            this.panelChild.Location = new System.Drawing.Point(113, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1182, 724);
            this.panelChild.TabIndex = 21;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.AutoScroll = true;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(992, 581);
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
            this.MinimizeButton.Location = new System.Drawing.Point(7, 654);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 37);
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
            this.CloseButton.Location = new System.Drawing.Point(54, 654);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 37);
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
            this.guna2Button16.Location = new System.Drawing.Point(29, 280);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(56, 48);
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
            this.guna2Button17.Location = new System.Drawing.Point(29, 137);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(56, 48);
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
            this.guna2Button18.Location = new System.Drawing.Point(29, 206);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(56, 48);
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
            this.guna2Button19.Location = new System.Drawing.Point(29, 371);
            this.guna2Button19.Name = "guna2Button19";
            this.guna2Button19.Size = new System.Drawing.Size(56, 48);
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
            this.guna2Button20.Location = new System.Drawing.Point(29, 66);
            this.guna2Button20.Name = "guna2Button20";
            this.guna2Button20.Size = new System.Drawing.Size(56, 48);
            this.guna2Button20.TabIndex = 0;
            this.guna2Button20.UseTransparentBackground = true;
            this.guna2Button20.Click += new System.EventHandler(this.guna2Button20_Click);
            // 
            // TeacherPanel_content
            // 
            this.TeacherPanel_content.AutoScroll = true;
            this.TeacherPanel_content.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TeacherPanel_content.Controls.Add(this.guna2Button7);
            this.TeacherPanel_content.Controls.Add(this.comboBox1);
            this.TeacherPanel_content.Controls.Add(this.guna2Panel3);
            this.TeacherPanel_content.Controls.Add(this.guna2Panel1);
            this.TeacherPanel_content.Controls.Add(this.Board1);
            this.TeacherPanel_content.Controls.Add(this.panel1);
            this.TeacherPanel_content.Controls.Add(this.pictureBox1);
            this.TeacherPanel_content.Controls.Add(this.label3);
            this.TeacherPanel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeacherPanel_content.Location = new System.Drawing.Point(115, 83);
            this.TeacherPanel_content.Name = "TeacherPanel_content";
            this.TeacherPanel_content.Size = new System.Drawing.Size(1180, 710);
            this.TeacherPanel_content.TabIndex = 21;
            this.TeacherPanel_content.Paint += new System.Windows.Forms.PaintEventHandler(this.TeacherPanel_content_Paint);
            // 
            // UserProfileTimer
            // 
            this.UserProfileTimer.Tick += new System.EventHandler(this.UserProfileTimer_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nunito Light", 36F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 66);
            this.label3.TabIndex = 31;
            this.label3.Tag = "";
            this.label3.Text = "DASHBOARD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StudentMana.Properties.Resources._403406882_313853028202794_1798676272926479777_n3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 275);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.timetxt);
            this.panel1.Location = new System.Drawing.Point(60, 417);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 69);
            this.panel1.TabIndex = 33;
            // 
            // timetxt
            // 
            this.timetxt.AutoSize = true;
            this.timetxt.BackColor = System.Drawing.Color.RoyalBlue;
            this.timetxt.Font = new System.Drawing.Font("Nunito SemiBold", 22.2F, System.Drawing.FontStyle.Bold);
            this.timetxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timetxt.Location = new System.Drawing.Point(15, 17);
            this.timetxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(86, 41);
            this.timetxt.TabIndex = 5;
            this.timetxt.Text = "Time";
            // 
            // Board1
            // 
            this.Board1.BackColor = System.Drawing.Color.Transparent;
            this.Board1.BorderColor = System.Drawing.Color.Transparent;
            this.Board1.BorderRadius = 50;
            this.Board1.BorderThickness = 1;
            this.Board1.Controls.Add(this.guna2HtmlLabel2);
            this.Board1.Controls.Add(this.guna2HtmlLabel1);
            this.Board1.Controls.Add(this.guna2PictureBox4);
            this.Board1.Controls.Add(this.Data1);
            this.Board1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Board1.CustomBorderColor = System.Drawing.Color.White;
            this.Board1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Board1.Location = new System.Drawing.Point(400, 148);
            this.Board1.Margin = new System.Windows.Forms.Padding(2);
            this.Board1.Name = "Board1";
            this.Board1.Size = new System.Drawing.Size(226, 186);
            this.Board1.TabIndex = 34;
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
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(15, 8);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(45, 44);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 2;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
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
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.Data3);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(658, 148);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(224, 186);
            this.guna2Panel1.TabIndex = 35;
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
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 50;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox6);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel3.Controls.Add(this.Data2);
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Location = new System.Drawing.Point(940, 148);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(203, 186);
            this.guna2Panel3.TabIndex = 27;
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
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(18, 8);
            this.guna2PictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(45, 44);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 2;
            this.guna2PictureBox6.TabStop = false;
            this.guna2PictureBox6.UseTransparentBackground = true;
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
            this.Data2.Location = new System.Drawing.Point(132, 144);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(57, 44);
            this.Data2.TabIndex = 3;
            this.Data2.Tag = "DataNumber";
            this.Data2.Text = "20";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Nunito", 18F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(699, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 41);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = " Chọn ngành";
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 10;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button7.Font = new System.Drawing.Font("Nunito Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button7.Location = new System.Drawing.Point(940, 39);
            this.guna2Button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(80, 40);
            this.guna2Button7.TabIndex = 36;
            this.guna2Button7.Text = "Reload";
            this.guna2Button7.UseTransparentBackground = true;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 793);
            this.Controls.Add(this.TeacherPanel_content);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.dropdownContainer.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.TeacherPanel_content.ResumeLayout(false);
            this.TeacherPanel_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Board1.ResumeLayout(false);
            this.Board1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timetxt;
        private Guna.UI2.WinForms.Guna2Panel Board1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label Data1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.Label Data3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Label Data2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
    }
}