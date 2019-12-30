namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxStayLogged = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxStayLogged
            // 
            this.checkBoxStayLogged.AutoSize = true;
            this.checkBoxStayLogged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxStayLogged.Location = new System.Drawing.Point(325, 506);
            this.checkBoxStayLogged.Name = "checkBoxStayLogged";
            this.checkBoxStayLogged.Size = new System.Drawing.Size(140, 24);
            this.checkBoxStayLogged.TabIndex = 3;
            this.checkBoxStayLogged.Text = "Remember Me";
            this.checkBoxStayLogged.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.logo_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(194, -41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackgroundImage = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.FBlogin2;
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogin.Location = new System.Drawing.Point(166, 325);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(450, 175);
            this.pictureBoxLogin.TabIndex = 4;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.Click += new System.EventHandler(this.pictureBoxLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 564);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.checkBoxStayLogged);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LikeWhosh";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxStayLogged;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

