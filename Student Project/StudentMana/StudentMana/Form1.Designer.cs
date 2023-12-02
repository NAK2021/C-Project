namespace StudentMana
{
    partial class Form1
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.QrScannerButton = new Guna.UI2.WinForms.Guna2Button();
            this.RememberPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RememberToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.EyeOpenButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonMinimze = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonClosed = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ForgotpassButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogInbutton = new Guna.UI2.WinForms.Guna2Button();
            this.EyeCloseButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.UserIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modalsettimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeOpenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Pink;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1242, 725);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_down);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_move);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1242, 725);
            this.guna2Panel2.TabIndex = 3;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1138, 45);
            this.guna2Panel3.TabIndex = 3;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            this.guna2Panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_down);
            this.guna2Panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_move);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::StudentMana.Properties.Resources.working7;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(58, 199);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(611, 399);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(183, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "School Scheduling";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Controls.Add(this.QrScannerButton);
            this.guna2CustomGradientPanel1.Controls.Add(this.RememberPass);
            this.guna2CustomGradientPanel1.Controls.Add(this.RememberToggle);
            this.guna2CustomGradientPanel1.Controls.Add(this.EyeOpenButton);
            this.guna2CustomGradientPanel1.Controls.Add(this.ButtonMinimze);
            this.guna2CustomGradientPanel1.Controls.Add(this.ButtonClosed);
            this.guna2CustomGradientPanel1.Controls.Add(this.ForgotpassButton);
            this.guna2CustomGradientPanel1.Controls.Add(this.LogInbutton);
            this.guna2CustomGradientPanel1.Controls.Add(this.EyeCloseButton);
            this.guna2CustomGradientPanel1.Controls.Add(this.UserIDTextBox);
            this.guna2CustomGradientPanel1.Controls.Add(this.PasswordText);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(829, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(413, 725);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // QrScannerButton
            // 
            this.QrScannerButton.Animated = true;
            this.QrScannerButton.BackColor = System.Drawing.Color.Transparent;
            this.QrScannerButton.BorderRadius = 10;
            this.QrScannerButton.DefaultAutoSize = true;
            this.QrScannerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.QrScannerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.QrScannerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.QrScannerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.QrScannerButton.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.QrScannerButton.ForeColor = System.Drawing.Color.White;
            this.QrScannerButton.Location = new System.Drawing.Point(64, 444);
            this.QrScannerButton.Name = "QrScannerButton";
            this.QrScannerButton.Size = new System.Drawing.Size(139, 33);
            this.QrScannerButton.TabIndex = 24;
            this.QrScannerButton.Text = "Scan QR here!";
            this.QrScannerButton.Click += new System.EventHandler(this.QrScannerButton_Click);
            // 
            // RememberPass
            // 
            this.RememberPass.BackColor = System.Drawing.Color.Transparent;
            this.RememberPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RememberPass.Location = new System.Drawing.Point(270, 405);
            this.RememberPass.Name = "RememberPass";
            this.RememberPass.Size = new System.Drawing.Size(93, 18);
            this.RememberPass.TabIndex = 22;
            this.RememberPass.Tag = "Remember Me";
            this.RememberPass.Text = "Remember Me";
            // 
            // RememberToggle
            // 
            this.RememberToggle.Checked = true;
            this.RememberToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RememberToggle.Location = new System.Drawing.Point(218, 405);
            this.RememberToggle.Name = "RememberToggle";
            this.RememberToggle.Size = new System.Drawing.Size(46, 18);
            this.RememberToggle.TabIndex = 3;
            this.RememberToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // EyeOpenButton
            // 
            this.EyeOpenButton.BackColor = System.Drawing.Color.Transparent;
            this.EyeOpenButton.Enabled = false;
            this.EyeOpenButton.Image = global::StudentMana.Properties.Resources.eyeopen;
            this.EyeOpenButton.ImageRotate = 0F;
            this.EyeOpenButton.Location = new System.Drawing.Point(307, 337);
            this.EyeOpenButton.Name = "EyeOpenButton";
            this.EyeOpenButton.Size = new System.Drawing.Size(34, 49);
            this.EyeOpenButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeOpenButton.TabIndex = 21;
            this.EyeOpenButton.TabStop = false;
            this.EyeOpenButton.Tag = "EyeButton";
            this.EyeOpenButton.UseTransparentBackground = true;
            this.EyeOpenButton.Visible = false;
            this.EyeOpenButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // ButtonMinimze
            // 
            this.ButtonMinimze.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimze.Image = global::StudentMana.Properties.Resources.minimize;
            this.ButtonMinimze.ImageRotate = 0F;
            this.ButtonMinimze.Location = new System.Drawing.Point(309, 26);
            this.ButtonMinimze.Name = "ButtonMinimze";
            this.ButtonMinimze.Size = new System.Drawing.Size(32, 10);
            this.ButtonMinimze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimze.TabIndex = 20;
            this.ButtonMinimze.TabStop = false;
            this.ButtonMinimze.UseTransparentBackground = true;
            this.ButtonMinimze.Click += new System.EventHandler(this.ButtonMinimze_Click);
            // 
            // ButtonClosed
            // 
            this.ButtonClosed.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClosed.Image = global::StudentMana.Properties.Resources.close;
            this.ButtonClosed.ImageRotate = 0F;
            this.ButtonClosed.Location = new System.Drawing.Point(354, 12);
            this.ButtonClosed.Name = "ButtonClosed";
            this.ButtonClosed.Size = new System.Drawing.Size(36, 34);
            this.ButtonClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClosed.TabIndex = 19;
            this.ButtonClosed.TabStop = false;
            this.ButtonClosed.UseTransparentBackground = true;
            this.ButtonClosed.Click += new System.EventHandler(this.ButtonClosed_Click);
            // 
            // ForgotpassButton
            // 
            this.ForgotpassButton.Animated = true;
            this.ForgotpassButton.BorderRadius = 10;
            this.ForgotpassButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ForgotpassButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ForgotpassButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ForgotpassButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ForgotpassButton.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotpassButton.ForeColor = System.Drawing.Color.White;
            this.ForgotpassButton.Location = new System.Drawing.Point(218, 444);
            this.ForgotpassButton.Name = "ForgotpassButton";
            this.ForgotpassButton.Size = new System.Drawing.Size(156, 33);
            this.ForgotpassButton.TabIndex = 18;
            this.ForgotpassButton.Text = "Forgot password?";
            this.ForgotpassButton.Click += new System.EventHandler(this.ForgotpassButton_Click);
            // 
            // LogInbutton
            // 
            this.LogInbutton.Animated = true;
            this.LogInbutton.BorderRadius = 10;
            this.LogInbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogInbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogInbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogInbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogInbutton.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Bold);
            this.LogInbutton.ForeColor = System.Drawing.Color.White;
            this.LogInbutton.Location = new System.Drawing.Point(123, 493);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(167, 38);
            this.LogInbutton.TabIndex = 17;
            this.LogInbutton.Text = "Log-in!";
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
            // 
            // EyeCloseButton
            // 
            this.EyeCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.EyeCloseButton.Image = global::StudentMana.Properties.Resources.icons8_eye_64;
            this.EyeCloseButton.ImageRotate = 0F;
            this.EyeCloseButton.Location = new System.Drawing.Point(309, 337);
            this.EyeCloseButton.Name = "EyeCloseButton";
            this.EyeCloseButton.Size = new System.Drawing.Size(32, 49);
            this.EyeCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeCloseButton.TabIndex = 16;
            this.EyeCloseButton.TabStop = false;
            this.EyeCloseButton.Tag = "EyeButton";
            this.EyeCloseButton.UseTransparentBackground = true;
            this.EyeCloseButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Animated = true;
            this.UserIDTextBox.BorderRadius = 10;
            this.UserIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserIDTextBox.DefaultText = "";
            this.UserIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserIDTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserIDTextBox.IconLeft = global::StudentMana.Properties.Resources.icon5;
            this.UserIDTextBox.Location = new System.Drawing.Point(64, 254);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.PasswordChar = '\0';
            this.UserIDTextBox.PlaceholderText = "User name....";
            this.UserIDTextBox.SelectedText = "";
            this.UserIDTextBox.Size = new System.Drawing.Size(292, 49);
            this.UserIDTextBox.TabIndex = 12;
            this.UserIDTextBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // PasswordText
            // 
            this.PasswordText.Animated = true;
            this.PasswordText.BorderRadius = 10;
            this.PasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordText.DefaultText = "";
            this.PasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordText.IconLeft = global::StudentMana.Properties.Resources.pass1;
            this.PasswordText.Location = new System.Drawing.Point(64, 337);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.PlaceholderText = "Password....";
            this.PasswordText.SelectedText = "";
            this.PasswordText.Size = new System.Drawing.Size(292, 49);
            this.PasswordText.TabIndex = 11;
            this.PasswordText.Tag = "EyeButton";
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome back to our group1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 725);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeOpenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeCloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox PasswordText;
        private Guna.UI2.WinForms.Guna2TextBox UserIDTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox EyeCloseButton;
        private Guna.UI2.WinForms.Guna2Button LogInbutton;
        private Guna.UI2.WinForms.Guna2PictureBox ButtonClosed;
        private Guna.UI2.WinForms.Guna2PictureBox ButtonMinimze;
        private System.Windows.Forms.Timer modalsettimer;
        private Guna.UI2.WinForms.Guna2PictureBox EyeOpenButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RememberToggle;
        private Guna.UI2.WinForms.Guna2HtmlLabel RememberPass;
        private Guna.UI2.WinForms.Guna2Button ForgotpassButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button QrScannerButton;
    }
}

