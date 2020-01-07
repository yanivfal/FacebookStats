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
            this.components = new System.ComponentModel.Container();
            this.userName = new System.Windows.Forms.Label();
            this.mainFormFacadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutLabel = new System.Windows.Forms.Label();
            this.userAlbumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.topCover = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.tabsNavigator = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormFacadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.RoyalBlue;
            this.userName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainFormFacadeBindingSource, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.Never, "User Name"));
            this.userName.Font = new System.Drawing.Font("Levenim MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Location = new System.Drawing.Point(297, 177);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(353, 80);
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
            this.logoutLabel.Location = new System.Drawing.Point(1515, 160);
            this.logoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(131, 46);
            this.logoutLabel.TabIndex = 9;
            this.logoutLabel.Text = "Logout";
            // 
            // userAlbumsBindingSource
            // 
            this.userAlbumsBindingSource.DataMember = "UserAlbums";
            this.userAlbumsBindingSource.DataSource = this.mainFormFacadeBindingSource;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.BackgroundImage = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.logOutWhite2;
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(1515, 31);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(142, 124);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // topCover
            // 
            this.topCover.BackColor = System.Drawing.Color.RoyalBlue;
            this.topCover.Location = new System.Drawing.Point(-2, -2);
            this.topCover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topCover.Name = "topCover";
            this.topCover.Size = new System.Drawing.Size(1694, 296);
            this.topCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topCover.TabIndex = 1;
            this.topCover.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mainFormFacadeBindingSource, "ProfilePicture", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.profilePicture.Location = new System.Drawing.Point(62, 31);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(194, 220);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // tabsNavigator
            // 
            this.tabsNavigator.Location = new System.Drawing.Point(0, 287);
            this.tabsNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.tabsNavigator.Name = "tabsNavigator";
            this.tabsNavigator.SelectedIndex = 0;
            this.tabsNavigator.Size = new System.Drawing.Size(1692, 1113);
            this.tabsNavigator.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabsNavigator.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1684, 1707);
            this.Controls.Add(this.tabsNavigator);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.topCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LikeWhosh";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormFacadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topCover;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.BindingSource mainFormFacadeBindingSource;
        private System.Windows.Forms.BindingSource userAlbumsBindingSource;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.TabControl tabsNavigator;
    }
}