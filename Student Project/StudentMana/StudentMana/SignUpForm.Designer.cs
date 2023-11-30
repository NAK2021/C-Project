namespace StudentMana
{
    partial class SignupForm
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
            this.ModalEffect_timer = new System.Windows.Forms.Timer(this.components);
            this.Closebutton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Closebutton
            // 
            this.Closebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Closebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Closebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Closebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Closebutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Closebutton.ForeColor = System.Drawing.Color.White;
            this.Closebutton.Location = new System.Drawing.Point(300, 274);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(180, 45);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.Text = "close";
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click_1);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Closebutton);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ModalEffect_timer;
        private Guna.UI2.WinForms.Guna2Button Closebutton;
    }
}