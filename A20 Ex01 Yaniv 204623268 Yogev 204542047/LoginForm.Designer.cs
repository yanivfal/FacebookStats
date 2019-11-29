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
            this.mainLabel = new System.Windows.Forms.Label();
            this.checkBoxStayLogged = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Levenim MT", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mainLabel.Location = new System.Drawing.Point(98, 9);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(846, 106);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Welcome to LIKEUSH";
            // 
            // checkBoxStayLogged
            // 
            this.checkBoxStayLogged.AutoSize = true;
            this.checkBoxStayLogged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxStayLogged.Location = new System.Drawing.Point(441, 350);
            this.checkBoxStayLogged.Name = "checkBoxStayLogged";
            this.checkBoxStayLogged.Size = new System.Drawing.Size(140, 24);
            this.checkBoxStayLogged.TabIndex = 3;
            this.checkBoxStayLogged.Text = "Remember Me";
            this.checkBoxStayLogged.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.FBlogin2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(302, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 183);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxStayLogged);
            this.Controls.Add(this.mainLabel);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.CheckBox checkBoxStayLogged;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

