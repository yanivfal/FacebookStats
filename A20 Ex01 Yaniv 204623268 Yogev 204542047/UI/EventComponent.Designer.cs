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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventComponent));
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.eventBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.endTimeLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkToFacebookLinkLabel = new System.Windows.Forms.LinkLabel();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.startTimeLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).BeginInit();
            this.eventBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // eventBindingNavigator
            // 
            this.eventBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventBindingNavigator.BindingSource = this.eventBindingSource;
            this.eventBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.eventBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eventBindingNavigatorSaveItem});
            this.eventBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventBindingNavigator.Name = "eventBindingNavigator";
            this.eventBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventBindingNavigator.Size = new System.Drawing.Size(1093, 47);
            this.eventBindingNavigator.TabIndex = 0;
            this.eventBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(87, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // eventBindingNavigatorSaveItem
            // 
            this.eventBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventBindingNavigatorSaveItem.Enabled = false;
            this.eventBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventBindingNavigatorSaveItem.Image")));
            this.eventBindingNavigatorSaveItem.Name = "eventBindingNavigatorSaveItem";
            this.eventBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.eventBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.Location = new System.Drawing.Point(27, 264);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(761, 185);
            this.descriptionLabel1.TabIndex = 2;
            this.descriptionLabel1.Text = "Event description";
            // 
            // endTimeLabel1
            // 
            this.endTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.endTimeLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.endTimeLabel1.Location = new System.Drawing.Point(334, 205);
            this.endTimeLabel1.Name = "endTimeLabel1";
            this.endTimeLabel1.Size = new System.Drawing.Size(232, 39);
            this.endTimeLabel1.TabIndex = 4;
            this.endTimeLabel1.Text = "End time";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(819, 135);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(244, 314);
            this.imageNormalPictureBox.TabIndex = 6;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkToFacebookLinkLabel
            // 
            this.linkToFacebookLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLinkLabel.Location = new System.Drawing.Point(453, 90);
            this.linkToFacebookLinkLabel.Name = "linkToFacebookLinkLabel";
            this.linkToFacebookLinkLabel.Size = new System.Drawing.Size(303, 43);
            this.linkToFacebookLinkLabel.TabIndex = 8;
            this.linkToFacebookLinkLabel.TabStop = true;
            this.linkToFacebookLinkLabel.Text = "Show in Facebook";
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.locationLabel1.Location = new System.Drawing.Point(23, 150);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(305, 63);
            this.locationLabel1.TabIndex = 10;
            this.locationLabel1.Text = "Location";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Levenim MT", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel1.Location = new System.Drawing.Point(19, 66);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(473, 67);
            this.nameLabel1.TabIndex = 12;
            this.nameLabel1.Text = "Event name";
            // 
            // startTimeLabel1
            // 
            this.startTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.startTimeLabel1.Font = new System.Drawing.Font("Levenim MT", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startTimeLabel1.Location = new System.Drawing.Point(25, 205);
            this.startTimeLabel1.Name = "startTimeLabel1";
            this.startTimeLabel1.Size = new System.Drawing.Size(213, 44);
            this.startTimeLabel1.TabIndex = 14;
            this.startTimeLabel1.Text = "Start time";
            // 
            // EventComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(this.endTimeLabel1);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(this.linkToFacebookLinkLabel);
            this.Controls.Add(this.locationLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.startTimeLabel1);
            this.Controls.Add(this.eventBindingNavigator);
            this.Name = "EventComponent";
            this.Size = new System.Drawing.Size(1093, 474);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).EndInit();
            this.eventBindingNavigator.ResumeLayout(false);
            this.eventBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingNavigator eventBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eventBindingNavigatorSaveItem;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label endTimeLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.LinkLabel linkToFacebookLinkLabel;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label startTimeLabel1;
    }
}
