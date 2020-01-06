namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    partial class WallPhotoComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocationLogo = new System.Windows.Forms.PictureBox();
            this.LikesLogo = new System.Windows.Forms.PictureBox();
            this.DateIcon = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LocationLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikesLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationLogo
            // 
            this.LocationLogo.BackColor = System.Drawing.Color.Transparent;
            this.LocationLogo.Image = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.LocationLogo2;
            this.LocationLogo.Location = new System.Drawing.Point(417, 1);
            this.LocationLogo.Name = "LocationLogo";
            this.LocationLogo.Size = new System.Drawing.Size(40, 40);
            this.LocationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LocationLogo.TabIndex = 3;
            this.LocationLogo.TabStop = false;
            // 
            // LikesLogo
            // 
            this.LikesLogo.BackColor = System.Drawing.Color.Transparent;
            this.LikesLogo.Image = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.likesLogo;
            this.LikesLogo.Location = new System.Drawing.Point(238, -3);
            this.LikesLogo.Name = "LikesLogo";
            this.LikesLogo.Size = new System.Drawing.Size(45, 45);
            this.LikesLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LikesLogo.TabIndex = 2;
            this.LikesLogo.TabStop = false;
            // 
            // DateIcon
            // 
            this.DateIcon.BackColor = System.Drawing.Color.Transparent;
            this.DateIcon.Image = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.DateLogo2;
            this.DateIcon.Location = new System.Drawing.Point(0, -10);
            this.DateIcon.Name = "DateIcon";
            this.DateIcon.Size = new System.Drawing.Size(60, 60);
            this.DateIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DateIcon.TabIndex = 1;
            this.DateIcon.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDate.Location = new System.Drawing.Point(50, 16);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 22);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikes.Location = new System.Drawing.Point(280, 16);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(48, 22);
            this.labelLikes.TabIndex = 5;
            this.labelLikes.Text = "Likes";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLocation.Location = new System.Drawing.Point(456, 16);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(77, 22);
            this.labelLocation.TabIndex = 6;
            this.labelLocation.Text = "Location";
            // 
            // WallPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.LocationLogo);
            this.Controls.Add(this.LikesLogo);
            this.Controls.Add(this.DateIcon);
            this.Name = "WallPhoto";
            this.Size = new System.Drawing.Size(533, 509);
            ((System.ComponentModel.ISupportInitialize)(this.LocationLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikesLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox DateIcon;
        private System.Windows.Forms.PictureBox LikesLogo;
        private System.Windows.Forms.PictureBox LocationLogo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelLocation;
    }
}
