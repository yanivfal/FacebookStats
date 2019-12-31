namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    partial class FriendComponent
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
            this.friendName = new System.Windows.Forms.Label();
            this.friendImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendImage)).BeginInit();
            this.SuspendLayout();
            // 
            // friendName
            // 
            this.friendName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.friendName.AutoSize = true;
            this.friendName.Font = new System.Drawing.Font("Levenim MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendName.Location = new System.Drawing.Point(14, 272);
            this.friendName.Name = "friendName";
            this.friendName.Size = new System.Drawing.Size(297, 53);
            this.friendName.TabIndex = 1;
            this.friendName.Text = "Friend Friendly";
            // 
            // friendImage
            // 
            this.friendImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendImage.Location = new System.Drawing.Point(0, 0);
            this.friendImage.Name = "friendImage";
            this.friendImage.Size = new System.Drawing.Size(314, 252);
            this.friendImage.TabIndex = 0;
            this.friendImage.TabStop = false;
            // 
            // FriendComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.friendName);
            this.Controls.Add(this.friendImage);
            this.Name = "FriendComponent";
            this.Size = new System.Drawing.Size(314, 350);
            ((System.ComponentModel.ISupportInitialize)(this.friendImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox friendImage;
        private System.Windows.Forms.Label friendName;
    }
}
