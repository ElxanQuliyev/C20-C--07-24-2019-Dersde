namespace C20_07._22._2019_Form_Shopp
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(385, 200);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(516, 332);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblWelcome.Location = new System.Drawing.Point(149, 62);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(79, 29);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "label1";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Ivory;
            this.btnRegister.Location = new System.Drawing.Point(29, 520);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 47);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Coral;
            this.btnLogin.Location = new System.Drawing.Point(962, 520);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 47);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1122, 628);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Ana Sehife";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
    }
}

