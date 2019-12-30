﻿namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
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
            this.components = new System.ComponentModel.Container();
            this.horoscopeButton = new System.Windows.Forms.Button();
            this.uploadStatisticsButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.mainFormFacadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutLabel = new System.Windows.Forms.Label();
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.topCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormFacadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).BeginInit();
            this.SuspendLayout();
            // 
            // horoscopeButton
            // 
            this.horoscopeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.horoscopeButton.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.horoscopeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horoscopeButton.Location = new System.Drawing.Point(35, 221);
            this.horoscopeButton.Margin = new System.Windows.Forms.Padding(2);
            this.horoscopeButton.Name = "horoscopeButton";
            this.horoscopeButton.Size = new System.Drawing.Size(398, 41);
            this.horoscopeButton.TabIndex = 4;
            this.horoscopeButton.Text = "Get your horoscope!";
            this.horoscopeButton.UseVisualStyleBackColor = false;
            this.horoscopeButton.Click += new System.EventHandler(this.horoscopeButton_Click);
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
            this.userName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormFacadeBindingSource, "m_UserName", true, System.Windows.Forms.DataSourceUpdateMode.Never, "User Name"));
            this.userName.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Location = new System.Drawing.Point(167, 114);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(213, 48);
            this.userName.TabIndex = 3;
            this.userName.Text = "User Name";
            // 
            // mainFormFacadeBindingSource
            // 
            this.mainFormFacadeBindingSource.DataSource = typeof(A20_Ex01_Yaniv_204623268_Yogev_204542047.Facades.MainFormFacade);
            // 
            // logoutLabel
            // 
            this.logoutLabel.AutoSize = true;
            this.logoutLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutLabel.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutLabel.ForeColor = System.Drawing.Color.White;
            this.logoutLabel.Location = new System.Drawing.Point(852, 103);
            this.logoutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(78, 27);
            this.logoutLabel.TabIndex = 9;
            this.logoutLabel.Text = "Logout";
            // 
            // comboBoxAlbums
            // 
            this.comboBoxAlbums.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAlbums.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(365, 294);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(214, 29);
            this.comboBoxAlbums.TabIndex = 10;
            this.comboBoxAlbums.Text = "Select Album";
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged_1);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.BackgroundImage = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.logOutWhite2;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(852, 20);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(80, 80);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mainFormFacadeBindingSource, "m_ProfilePicture", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.profilePicture.Location = new System.Drawing.Point(35, 20);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(109, 142);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // topCover
            // 
            this.topCover.BackColor = System.Drawing.Color.RoyalBlue;
            this.topCover.Location = new System.Drawing.Point(-1, -1);
            this.topCover.Margin = new System.Windows.Forms.Padding(2);
            this.topCover.Name = "topCover";
            this.topCover.Size = new System.Drawing.Size(953, 191);
            this.topCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topCover.TabIndex = 1;
            this.topCover.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(947, 701);
            this.Controls.Add(this.comboBoxAlbums);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.uploadStatisticsButton);
            this.Controls.Add(this.horoscopeButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.topCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LikeWhosh";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormFacadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topCover;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button horoscopeButton;
        private System.Windows.Forms.Button uploadStatisticsButton;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.BindingSource mainFormFacadeBindingSource;
    }
}