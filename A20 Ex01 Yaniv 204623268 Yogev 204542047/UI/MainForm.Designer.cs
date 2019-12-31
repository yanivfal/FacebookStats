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
            this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
            this.userAlbumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutButton = new System.Windows.Forms.PictureBox();
            this.topCover = new System.Windows.Forms.PictureBox();
            this.tabsNavigator = new System.Windows.Forms.TabControl();
            this.tabWall = new System.Windows.Forms.TabPage();
            this.tabLikesDist = new System.Windows.Forms.TabPage();
            this.tabHoroscope = new System.Windows.Forms.TabPage();
            this.tabFreindList = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.labelEventTitle = new System.Windows.Forms.Label();
            this.labelFriendsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormFacadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).BeginInit();
            this.tabsNavigator.SuspendLayout();
            this.tabWall.SuspendLayout();
            this.tabFreindList.SuspendLayout();
            this.tabEvents.SuspendLayout();
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
            this.comboBoxAlbums.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mainFormFacadeBindingSource, "SelectedAlbum", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxAlbums.DataSource = this.userAlbumsBindingSource;
            this.comboBoxAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxAlbums.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxAlbums.FormattingEnabled = true;
            this.comboBoxAlbums.Location = new System.Drawing.Point(316, 22);
            this.comboBoxAlbums.Name = "comboBoxAlbums";
            this.comboBoxAlbums.Size = new System.Drawing.Size(214, 29);
            this.comboBoxAlbums.TabIndex = 10;
            this.comboBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbums_SelectedIndexChanged_1);
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
            this.logoutButton.Location = new System.Drawing.Point(852, 20);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(80, 80);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.TabStop = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // tabsNavigator
            // 
            this.tabsNavigator.Controls.Add(this.tabWall);
            this.tabsNavigator.Controls.Add(this.tabLikesDist);
            this.tabsNavigator.Controls.Add(this.tabHoroscope);
            this.tabsNavigator.Controls.Add(this.tabFreindList);
            this.tabsNavigator.Controls.Add(this.tabEvents);
            this.tabsNavigator.Location = new System.Drawing.Point(0, 185);
            this.tabsNavigator.Name = "tabsNavigator";
            this.tabsNavigator.SelectedIndex = 0;
            this.tabsNavigator.Size = new System.Drawing.Size(952, 718);
            this.tabsNavigator.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabsNavigator.TabIndex = 11;
            // 
            // tabWall
            // 
            this.tabWall.AutoScroll = true;
            this.tabWall.BackColor = System.Drawing.SystemColors.Control;
            this.tabWall.Controls.Add(this.comboBoxAlbums);
            this.tabWall.Location = new System.Drawing.Point(4, 29);
            this.tabWall.Name = "tabWall";
            this.tabWall.Padding = new System.Windows.Forms.Padding(3);
            this.tabWall.Size = new System.Drawing.Size(944, 685);
            this.tabWall.TabIndex = 0;
            this.tabWall.Text = "Wall";
            // 
            // tabLikesDist
            // 
            this.tabLikesDist.BackColor = System.Drawing.SystemColors.Control;
            this.tabLikesDist.Location = new System.Drawing.Point(4, 29);
            this.tabLikesDist.Name = "tabLikesDist";
            this.tabLikesDist.Padding = new System.Windows.Forms.Padding(3);
            this.tabLikesDist.Size = new System.Drawing.Size(944, 685);
            this.tabLikesDist.TabIndex = 1;
            this.tabLikesDist.Text = "Likes Distribution";
            // 
            // tabHoroscope
            // 
            this.tabHoroscope.BackColor = System.Drawing.SystemColors.Control;
            this.tabHoroscope.Location = new System.Drawing.Point(4, 29);
            this.tabHoroscope.Name = "tabHoroscope";
            this.tabHoroscope.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoroscope.Size = new System.Drawing.Size(944, 685);
            this.tabHoroscope.TabIndex = 2;
            this.tabHoroscope.Text = "Horoscope";
            // 
            // tabFreindList
            // 
            this.tabFreindList.AutoScroll = true;
            this.tabFreindList.BackColor = System.Drawing.SystemColors.Control;
            this.tabFreindList.Controls.Add(this.labelFriendsTitle);
            this.tabFreindList.Location = new System.Drawing.Point(4, 29);
            this.tabFreindList.Name = "tabFreindList";
            this.tabFreindList.Padding = new System.Windows.Forms.Padding(3);
            this.tabFreindList.Size = new System.Drawing.Size(944, 685);
            this.tabFreindList.TabIndex = 3;
            this.tabFreindList.Text = "Friends List";
            // 
            // tabEvents
            // 
            this.tabEvents.AutoScroll = true;
            this.tabEvents.BackColor = System.Drawing.SystemColors.Control;
            this.tabEvents.Controls.Add(this.labelEventTitle);
            this.tabEvents.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabEvents.Location = new System.Drawing.Point(4, 29);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(944, 685);
            this.tabEvents.TabIndex = 4;
            this.tabEvents.Text = "Events";
            // 
            // profilePicture
            // 
            this.profilePicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mainFormFacadeBindingSource, "ProfilePicture", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.profilePicture.Location = new System.Drawing.Point(35, 20);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(109, 142);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // labelEventTitle
            // 
            this.labelEventTitle.AutoSize = true;
            this.labelEventTitle.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventTitle.Location = new System.Drawing.Point(445, 26);
            this.labelEventTitle.Name = "labelEventTitle";
            this.labelEventTitle.Size = new System.Drawing.Size(227, 27);
            this.labelEventTitle.TabIndex = 0;
            this.labelEventTitle.Text = "Your following events:";
            // 
            // labelFriendsTitle
            // 
            this.labelFriendsTitle.AutoSize = true;
            this.labelFriendsTitle.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendsTitle.Location = new System.Drawing.Point(382, 25);
            this.labelFriendsTitle.Name = "labelFriendsTitle";
            this.labelFriendsTitle.Size = new System.Drawing.Size(118, 27);
            this.labelFriendsTitle.TabIndex = 1;
            this.labelFriendsTitle.Text = "Friends list:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(947, 1046);
            this.Controls.Add(this.tabsNavigator);
            this.Controls.Add(this.logoutLabel);
            this.Controls.Add(this.logoutButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.userAlbumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topCover)).EndInit();
            this.tabsNavigator.ResumeLayout(false);
            this.tabWall.ResumeLayout(false);
            this.tabFreindList.ResumeLayout(false);
            this.tabFreindList.PerformLayout();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topCover;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.PictureBox logoutButton;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.BindingSource mainFormFacadeBindingSource;
        private System.Windows.Forms.BindingSource userAlbumsBindingSource;
        private System.Windows.Forms.TabControl tabsNavigator;
        private System.Windows.Forms.TabPage tabWall;
        private System.Windows.Forms.TabPage tabLikesDist;
        private System.Windows.Forms.TabPage tabHoroscope;
        private System.Windows.Forms.TabPage tabFreindList;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label labelFriendsTitle;
        private System.Windows.Forms.Label labelEventTitle;
    }
}