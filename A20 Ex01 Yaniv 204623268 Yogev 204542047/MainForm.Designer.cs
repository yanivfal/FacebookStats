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
            this.likeStatisticsButton = new System.Windows.Forms.Button();
            this.uploadStatisticsButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPhoto
            // 
            this.coverPhoto.BackColor = System.Drawing.Color.RoyalBlue;
            this.coverPhoto.Location = new System.Drawing.Point(0, -2);
            this.coverPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.coverPhoto.Name = "coverPhoto";
            this.coverPhoto.Size = new System.Drawing.Size(2012, 191);
            this.coverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPhoto.TabIndex = 1;
            this.coverPhoto.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(35, 20);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(109, 142);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // likeStatisticsButton
            // 
            this.likeStatisticsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.likeStatisticsButton.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likeStatisticsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeStatisticsButton.Location = new System.Drawing.Point(35, 221);
            this.likeStatisticsButton.Margin = new System.Windows.Forms.Padding(2);
            this.likeStatisticsButton.Name = "likeStatisticsButton";
            this.likeStatisticsButton.Size = new System.Drawing.Size(398, 41);
            this.likeStatisticsButton.TabIndex = 4;
            this.likeStatisticsButton.Text = "Who like me at most?";
            this.likeStatisticsButton.UseVisualStyleBackColor = false;
            // 
            // uploadStatisticsButton
            // 
            this.uploadStatisticsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.uploadStatisticsButton.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uploadStatisticsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadStatisticsButton.Location = new System.Drawing.Point(471, 222);
            this.uploadStatisticsButton.Margin = new System.Windows.Forms.Padding(2);
            this.uploadStatisticsButton.Name = "uploadStatisticsButton";
            this.uploadStatisticsButton.Size = new System.Drawing.Size(432, 40);
            this.uploadStatisticsButton.TabIndex = 5;
            this.uploadStatisticsButton.Text = "When should I upload photos?";
            this.uploadStatisticsButton.UseVisualStyleBackColor = false;
            this.uploadStatisticsButton.Click += new System.EventHandler(this.uploadStatisticsButton_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.RoyalBlue;
            this.userName.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Location = new System.Drawing.Point(167, 114);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(213, 48);
            this.userName.TabIndex = 3;
            this.userName.Text = "User Name";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogOut.Location = new System.Drawing.Point(842, 20);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(79, 73);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 944);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.uploadStatisticsButton);
            this.Controls.Add(this.likeStatisticsButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.coverPhoto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadStatisticsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coverPhoto;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button likeStatisticsButton;
        private System.Windows.Forms.Button uploadStatisticsButton;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button buttonLogOut;
    }
}