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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.checkBoxStayLogged = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Font = new System.Drawing.Font("Levenim MT", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.Location = new System.Drawing.Point(498, 170);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(284, 115);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login To Facebook";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
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
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Levenim MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.subLabel.Location = new System.Drawing.Point(158, 209);
            this.subLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(218, 37);
            this.subLabel.TabIndex = 2;
            this.subLabel.Text = "To start, please";
            // 
            // checkBoxStayLogged
            // 
            this.checkBoxStayLogged.AutoSize = true;
            this.checkBoxStayLogged.Location = new System.Drawing.Point(396, 348);
            this.checkBoxStayLogged.Name = "checkBoxStayLogged";
            this.checkBoxStayLogged.Size = new System.Drawing.Size(140, 24);
            this.checkBoxStayLogged.TabIndex = 3;
            this.checkBoxStayLogged.Text = "Remember Me";
            this.checkBoxStayLogged.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 496);
            this.Controls.Add(this.checkBoxStayLogged);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.buttonLogin);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.CheckBox checkBoxStayLogged;
    }
}

