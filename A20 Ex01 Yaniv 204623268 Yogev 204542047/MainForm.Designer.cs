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
            this.likeStatisticsButton = new System.Windows.Forms.Button();
            this.uploadStatisticsButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.logoutLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.topCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).BeginInit();
            this.SuspendLayout();
            // 
            // likeStatisticsButton
            // 
            this.likeStatisticsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.likeStatisticsButton.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likeStatisticsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.likeStatisticsButton.Location = new System.Drawing.Point(62, 343);
            this.likeStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.likeStatisticsButton.Name = "likeStatisticsButton";
            this.likeStatisticsButton.Size = new System.Drawing.Size(708, 64);
            this.likeStatisticsButton.TabIndex = 4;
            this.likeStatisticsButton.Text = "Who like me at most?";
            this.likeStatisticsButton.UseVisualStyleBackColor = false;
            this.likeStatisticsButton.Click += new System.EventHandler(this.likeStatisticsButton_Click_1);
            // 
            // uploadStatisticsButton
            // 
            this.uploadStatisticsButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.uploadStatisticsButton.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.uploadStatisticsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadStatisticsButton.Location = new System.Drawing.Point(837, 344);
            this.uploadStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uploadStatisticsButton.Name = "uploadStatisticsButton";
            this.uploadStatisticsButton.Size = new System.Drawing.Size(768, 62);
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
            this.userName.Location = new System.Drawing.Point(297, 177);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(353, 80);
            this.userName.TabIndex = 3;
            this.userName.Text = "User Name";
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutLabel.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutLabel.ForeColor = System.Drawing.Color.White;
            this.logoutLabel.Location = new System.Drawing.Point(1515, 160);
            this.logoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(131, 46);
            this.logoutLabel.TabIndex = 9;
            this.logoutLabel.Text = "Logout";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.BackgroundImage = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.logOutWhite2;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.InitialImage = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.logout__1_;
            this.logoutButton.Location = new System.Drawing.Point(1515, 31);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(142, 124);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(62, 31);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(194, 220);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // topCover
            // 
            this.topCover.BackColor = System.Drawing.Color.RoyalBlue;
            this.topCover.Location = new System.Drawing.Point(0, -3);
            this.topCover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topCover.Name = "topCover";
            this.topCover.Size = new System.Drawing.Size(3577, 296);
            this.topCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topCover.TabIndex = 1;
            this.topCover.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1684, 1668);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.uploadStatisticsButton);
            this.Controls.Add(this.likeStatisticsButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.topCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UploadStatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topCover;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button likeStatisticsButton;
        private System.Windows.Forms.Button uploadStatisticsButton;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.Label logoutLabel;
    }
}