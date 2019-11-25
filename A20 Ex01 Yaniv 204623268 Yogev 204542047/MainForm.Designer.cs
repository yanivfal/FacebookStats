namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    partial class MainForm
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
            this.coverPhoto = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.likeStatisticsButton = new System.Windows.Forms.Button();
            this.uploadStatisticsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPhoto
            // 
            this.coverPhoto.Location = new System.Drawing.Point(0, 0);
            this.coverPhoto.Name = "coverPhoto";
            this.coverPhoto.Size = new System.Drawing.Size(1683, 412);
            this.coverPhoto.TabIndex = 1;
            this.coverPhoto.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(82, 279);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(257, 287);
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userName.Location = new System.Drawing.Point(373, 429);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(353, 80);
            this.userName.TabIndex = 3;
            this.userName.Text = "User Name";
            // 
            // likeStatisticsButton
            // 
            this.likeStatisticsButton.Font = new System.Drawing.Font("Levenim MT", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likeStatisticsButton.Location = new System.Drawing.Point(506, 644);
            this.likeStatisticsButton.Name = "likeStatisticsButton";
            this.likeStatisticsButton.Size = new System.Drawing.Size(447, 168);
            this.likeStatisticsButton.TabIndex = 4;
            this.likeStatisticsButton.Text = "Who like me at most?";
            this.likeStatisticsButton.UseVisualStyleBackColor = true;
            this.likeStatisticsButton.Click += new System.EventHandler(this.likeStatisticsButton_Click);
            // 
            // uploadStatisticsButton
            // 
            this.uploadStatisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uploadStatisticsButton.Font = new System.Drawing.Font("Levenim MT", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uploadStatisticsButton.Location = new System.Drawing.Point(1053, 644);
            this.uploadStatisticsButton.Name = "uploadStatisticsButton";
            this.uploadStatisticsButton.Size = new System.Drawing.Size(447, 168);
            this.uploadStatisticsButton.TabIndex = 5;
            this.uploadStatisticsButton.Text = "When should I upload photos?";
            this.uploadStatisticsButton.UseVisualStyleBackColor = false;
            this.uploadStatisticsButton.Click += new System.EventHandler(this.uploadStatisticsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 841);
            this.Controls.Add(this.uploadStatisticsButton);
            this.Controls.Add(this.likeStatisticsButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.coverPhoto);
            this.Name = "MainForm";
            this.Text = "UploadStatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPhoto;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button likeStatisticsButton;
        private System.Windows.Forms.Button uploadStatisticsButton;
    }
}