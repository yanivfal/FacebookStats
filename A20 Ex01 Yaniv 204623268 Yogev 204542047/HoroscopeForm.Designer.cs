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
        private void InitializeComponent()
        {
            this.pictureBoxHoroscope = new System.Windows.Forms.PictureBox();
            this.labelHoroscopeTitle = new System.Windows.Forms.Label();
            this.buttonHoroscopeResolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoroscope)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHoroscope
            // 
            this.pictureBoxHoroscope.Image = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.horoscopesLogo;
            this.pictureBoxHoroscope.Location = new System.Drawing.Point(231, 84);
            this.pictureBoxHoroscope.Name = "pictureBoxHoroscope";
            this.pictureBoxHoroscope.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxHoroscope.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHoroscope.TabIndex = 0;
            this.pictureBoxHoroscope.TabStop = false;
            // 
            // labelHoroscopeTitle
            // 
            this.labelHoroscopeTitle.AutoSize = true;
            this.labelHoroscopeTitle.Font = new System.Drawing.Font("Levenim MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHoroscopeTitle.Location = new System.Drawing.Point(287, 31);
            this.labelHoroscopeTitle.Name = "labelHoroscopeTitle";
            this.labelHoroscopeTitle.Size = new System.Drawing.Size(189, 30);
            this.labelHoroscopeTitle.TabIndex = 1;
            this.labelHoroscopeTitle.Text = "Horoscope Zone";
            // 
            // buttonHoroscopeResolve
            // 
            this.buttonHoroscopeResolve.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonHoroscopeResolve.Location = new System.Drawing.Point(231, 415);
            this.buttonHoroscopeResolve.Name = "buttonHoroscopeResolve";
            this.buttonHoroscopeResolve.Size = new System.Drawing.Size(302, 30);
            this.buttonHoroscopeResolve.TabIndex = 2;
            this.buttonHoroscopeResolve.Text = "Click here to get your horoscope";
            this.buttonHoroscopeResolve.UseVisualStyleBackColor = true;
            // 
            // HoroscopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(763, 556);
            this.Controls.Add(this.buttonHoroscopeResolve);
            this.Controls.Add(this.labelHoroscopeTitle);
            this.Controls.Add(this.pictureBoxHoroscope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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