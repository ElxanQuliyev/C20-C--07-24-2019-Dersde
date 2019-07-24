namespace C20_07._22._2019_Form_Shopp
{
    partial class LoginPage
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Ivory;
            this.btnRegister.Location = new System.Drawing.Point(469, 389);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(179, 47);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Login";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(469, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 26);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(466, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(469, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(466, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.DarkRed;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.SeaShell;
            this.lblError.Location = new System.Drawing.Point(466, 306);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(57, 24);
            this.lblError.TabIndex = 16;
            this.lblError.Text = "Email";
            this.lblError.Visible = false;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.Location = new System.Drawing.Point(470, 333);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(133, 24);
            this.chkRemember.TabIndex = 17;
            this.chkRemember.Text = "Remember Me";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 685);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkRemember;
    }
}