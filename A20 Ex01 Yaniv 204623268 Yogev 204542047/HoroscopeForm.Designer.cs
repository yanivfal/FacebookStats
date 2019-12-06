namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    partial class HoroscopeForm
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
        private void initializeComponent()
        {
            this.labelHoroscopeTitle = new System.Windows.Forms.Label();
            this.buttonHoroscopeResolve = new System.Windows.Forms.Button();
            this.pictureBoxHoroscope = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoroscope)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHoroscopeTitle
            // 
            this.labelHoroscopeTitle.AutoSize = true;
            this.labelHoroscopeTitle.Font = new System.Drawing.Font("Levenim MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHoroscopeTitle.Location = new System.Drawing.Point(510, 48);
            this.labelHoroscopeTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHoroscopeTitle.Name = "labelHoroscopeTitle";
            this.labelHoroscopeTitle.Size = new System.Drawing.Size(320, 50);
            this.labelHoroscopeTitle.TabIndex = 1;
            this.labelHoroscopeTitle.Text = "Horoscope Zone";
            // 
            // buttonHoroscopeResolve
            // 
            this.buttonHoroscopeResolve.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonHoroscopeResolve.Location = new System.Drawing.Point(411, 643);
            this.buttonHoroscopeResolve.Margin = new System.Windows.Forms.Padding(5);
            this.buttonHoroscopeResolve.Name = "buttonHoroscopeResolve";
            this.buttonHoroscopeResolve.Size = new System.Drawing.Size(537, 46);
            this.buttonHoroscopeResolve.TabIndex = 2;
            this.buttonHoroscopeResolve.Text = "Click here to get your horoscope";
            this.buttonHoroscopeResolve.UseVisualStyleBackColor = true;
            this.buttonHoroscopeResolve.Click += new System.EventHandler(this.buttonHoroscopeResolve_Click);
            // 
            // pictureBoxHoroscope
            // 
            this.pictureBoxHoroscope.Image = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.horoscopesLogo;
            this.pictureBoxHoroscope.Location = new System.Drawing.Point(411, 130);
            this.pictureBoxHoroscope.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxHoroscope.Name = "pictureBoxHoroscope";
            this.pictureBoxHoroscope.Size = new System.Drawing.Size(533, 465);
            this.pictureBoxHoroscope.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHoroscope.TabIndex = 0;
            this.pictureBoxHoroscope.TabStop = false;
            // 
            // HoroscopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1356, 862);
            this.Controls.Add(this.buttonHoroscopeResolve);
            this.Controls.Add(this.labelHoroscopeTitle);
            this.Controls.Add(this.pictureBoxHoroscope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "HoroscopeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horoscope";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoroscope)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHoroscope;
        private System.Windows.Forms.Label labelHoroscopeTitle;
        private System.Windows.Forms.Button buttonHoroscopeResolve;
    }
}