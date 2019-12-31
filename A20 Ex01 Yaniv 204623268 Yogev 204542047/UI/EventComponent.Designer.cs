namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    partial class EventComponent
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
            this.components = new System.ComponentModel.Container();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.endTimeLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.startTimeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(15, 170);
            this.descriptionLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(428, 119);
            this.descriptionLabel1.TabIndex = 2;
            this.descriptionLabel1.Text = "Event description";
            // 
            // endTimeLabel1
            // 
            this.endTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.endTimeLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.endTimeLabel1.Location = new System.Drawing.Point(188, 132);
            this.endTimeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLabel1.Name = "endTimeLabel1";
            this.endTimeLabel1.Size = new System.Drawing.Size(130, 25);
            this.endTimeLabel1.TabIndex = 4;
            this.endTimeLabel1.Text = "End time";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(461, 87);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(137, 203);
            this.imageNormalPictureBox.TabIndex = 6;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(255, 58);
            this.linkToFacebookLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(170, 28);
            this.linkToFacebookLinkLabel.TabIndex = 8;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "Show in Facebook";
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.locationLabel1.Location = new System.Drawing.Point(13, 97);
            this.locationLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(172, 41);
            this.locationLabel1.TabIndex = 10;
            this.locationLabel1.Text = "Location";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Levenim MT", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(11, 43);
            this.nameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(266, 43);
            this.nameLabel1.TabIndex = 12;
            this.nameLabel1.Text = "Event name";
            // 
            // startTimeLabel1
            // 
            this.startTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.startTimeLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startTimeLabel1.Location = new System.Drawing.Point(14, 132);
            this.startTimeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLabel1.Name = "startTimeLabel1";
            this.startTimeLabel1.Size = new System.Drawing.Size(120, 28);
            this.startTimeLabel1.TabIndex = 14;
            this.startTimeLabel1.Text = "Start time";
            // 
            // EventComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.endTimeLabel1);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.linkToFacebookLinkLabel);
            this.Controls.Add(this.locationLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.startTimeLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EventComponent";
            this.Size = new System.Drawing.Size(615, 306);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label endTimeLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.LinkLabel linkToFacebookLinkLabel;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label startTimeLabel1;
    }
}
