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
            this.panelEvent = new System.Windows.Forms.Panel();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventLocation = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelEventStartt = new System.Windows.Forms.Label();
            this.labelEventEnd = new System.Windows.Forms.Label();
            this.panelEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEvent
            // 
            this.panelEvent.Controls.Add(this.labelEventEnd);
            this.panelEvent.Controls.Add(this.labelEventStartt);
            this.panelEvent.Controls.Add(this.labelEventDate);
            this.panelEvent.Controls.Add(this.labelEventLocation);
            this.panelEvent.Controls.Add(this.labelEventName);
            this.panelEvent.Location = new System.Drawing.Point(4, 4);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(307, 208);
            this.panelEvent.TabIndex = 0;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventName.Location = new System.Drawing.Point(29, 26);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(131, 27);
            this.labelEventName.TabIndex = 0;
            this.labelEventName.Text = "Event Name";
            // 
            // labelEventLocation
            // 
            this.labelEventLocation.AutoSize = true;
            this.labelEventLocation.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventLocation.Location = new System.Drawing.Point(29, 61);
            this.labelEventLocation.Name = "labelEventLocation";
            this.labelEventLocation.Size = new System.Drawing.Size(102, 27);
            this.labelEventLocation.TabIndex = 1;
            this.labelEventLocation.Text = "Location:";
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventDate.Location = new System.Drawing.Point(29, 92);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(66, 27);
            this.labelEventDate.TabIndex = 2;
            this.labelEventDate.Text = "Date:";
            // 
            // labelEventStartt
            // 
            this.labelEventStartt.AutoSize = true;
            this.labelEventStartt.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventStartt.Location = new System.Drawing.Point(29, 125);
            this.labelEventStartt.Name = "labelEventStartt";
            this.labelEventStartt.Size = new System.Drawing.Size(89, 27);
            this.labelEventStartt.TabIndex = 3;
            this.labelEventStartt.Text = "Start at:";
            // 
            // labelEventEnd
            // 
            this.labelEventEnd.AutoSize = true;
            this.labelEventEnd.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventEnd.Location = new System.Drawing.Point(29, 156);
            this.labelEventEnd.Name = "labelEventEnd";
            this.labelEventEnd.Size = new System.Drawing.Size(82, 27);
            this.labelEventEnd.TabIndex = 4;
            this.labelEventEnd.Text = "End at:";
            // 
            // EventComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEvent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventComponent";
            this.Size = new System.Drawing.Size(308, 215);
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEvent;
        public System.Windows.Forms.Label labelEventEnd;
        public System.Windows.Forms.Label labelEventStartt;
        public System.Windows.Forms.Label labelEventDate;
        public System.Windows.Forms.Label labelEventLocation;
        public System.Windows.Forms.Label labelEventName;
    }
}
