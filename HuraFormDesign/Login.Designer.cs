namespace HuraFormDesign
{
    partial class Login
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
            this.huraCheckBox1 = new Hura_Theme.HuraCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.passx = new Hura_Theme.HuraTextBox();
            this.huraButton1 = new Hura_Theme.HuraButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.alertx = new Hura_Theme.HuraAlertBox();
            this.userx = new Hura_Theme.HuraTextBox();
            this.SuspendLayout();
            // 
            // huraCheckBox1
            // 
            this.huraCheckBox1.Checked = false;
            this.huraCheckBox1.Location = new System.Drawing.Point(296, 208);
            this.huraCheckBox1.Name = "huraCheckBox1";
            this.huraCheckBox1.Size = new System.Drawing.Size(98, 23);
            this.huraCheckBox1.TabIndex = 19;
            this.huraCheckBox1.Text = "Remeber Me ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.linkLabel2.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel2.Location = new System.Drawing.Point(10, 347);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 13);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "www.example.com/Home";
            // 
            // passx
            // 
            this.passx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.passx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passx.ColorScheme = Hura_Theme.HuraTextBox.ColorSchemes.Dark;
            this.passx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passx.ForeColor = System.Drawing.Color.White;
            this.passx.Location = new System.Drawing.Point(13, 173);
            this.passx.Name = "passx";
            this.passx.Size = new System.Drawing.Size(381, 29);
            this.passx.TabIndex = 15;
            this.passx.UseSystemPasswordChar = true;
            // 
            // huraButton1
            // 
            this.huraButton1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.huraButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.huraButton1.ColorScheme = Hura_Theme.HuraButton.ColorSchemes.Dark;
            this.huraButton1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.huraButton1.ForeColor = System.Drawing.Color.White;
            this.huraButton1.Location = new System.Drawing.Point(13, 208);
            this.huraButton1.Name = "huraButton1";
            this.huraButton1.Size = new System.Drawing.Size(216, 36);
            this.huraButton1.TabIndex = 14;
            this.huraButton1.Text = "Login";
            this.huraButton1.UseVisualStyleBackColor = false;
            this.huraButton1.Click += new System.EventHandler(this.huraButton1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(312, 153);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Details ?";
            // 
            // alertx
            // 
            this.alertx.AlertStyle = Hura_Theme.HuraAlertBox.Style.Simple;
            this.alertx.BackColor = System.Drawing.Color.Red;
            this.alertx.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.alertx.Font = new System.Drawing.Font("Verdana", 8F);
            this.alertx.Location = new System.Drawing.Point(13, 30);
            this.alertx.Name = "alertx";
            this.alertx.Size = new System.Drawing.Size(381, 40);
            this.alertx.TabIndex = 12;
            this.alertx.Text = "Please Enter Your Login Details";
            // 
            // userx
            // 
            this.userx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userx.ColorScheme = Hura_Theme.HuraTextBox.ColorSchemes.Dark;
            this.userx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userx.ForeColor = System.Drawing.Color.White;
            this.userx.Location = new System.Drawing.Point(13, 110);
            this.userx.Multiline = true;
            this.userx.Name = "userx";
            this.userx.Size = new System.Drawing.Size(381, 28);
            this.userx.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(405, 369);
            this.Controls.Add(this.huraCheckBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.passx);
            this.Controls.Add(this.huraButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.alertx);
            this.Controls.Add(this.userx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Name | Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hura_Theme.HuraCheckBox huraCheckBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Hura_Theme.HuraTextBox passx;
        private Hura_Theme.HuraButton huraButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Hura_Theme.HuraAlertBox alertx;
        private Hura_Theme.HuraTextBox userx;


    }
}

