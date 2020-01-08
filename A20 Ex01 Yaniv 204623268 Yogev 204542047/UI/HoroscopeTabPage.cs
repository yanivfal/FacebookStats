using A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    class HoroscopeTabPage : TabPage
    {
        eZodiacs m_ZodiacName;
        Label labelHoroscopeTitle;
        Button buttonHoroscopeResolve;
        PictureBox pictureBoxHoroscope;

        public HoroscopeTabPage(string i_TabText) : base(i_TabText)
        {
            initializeComponent();
            locateAllControls();
            fetchHoroscopeNameAndImage();

            ControlsUtils.CenteringAllControls(this, this.Width);
        }

        private void initializeComponent()
        {
            this.Width = AppSettings.Instance.MainWindowWidth;
            this.Height = AppSettings.Instance.MainWindowHeight;


            this.labelHoroscopeTitle = new System.Windows.Forms.Label();
            this.buttonHoroscopeResolve = new System.Windows.Forms.Button();
            this.pictureBoxHoroscope = new System.Windows.Forms.PictureBox();
            //((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoroscope)).BeginInit();
            //this.SuspendLayout();
            // 
            // labelHoroscopeTitle
            // 
            this.labelHoroscopeTitle.AutoSize = true;
            this.labelHoroscopeTitle.Font = new System.Drawing.Font("Levenim MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            //this.labelHoroscopeTitle.Location = new System.Drawing.Point(510, 48);
            this.labelHoroscopeTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHoroscopeTitle.Name = "labelHoroscopeTitle";
            //this.labelHoroscopeTitle.Size = new System.Drawing.Size(320, 50);
            //this.labelHoroscopeTitle.TabIndex = 1;
            this.labelHoroscopeTitle.Text = "Horoscope Zone";
            // 
            // buttonHoroscopeResolve
            // 
            this.buttonHoroscopeResolve.Font = new System.Drawing.Font("Levenim MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonHoroscopeResolve.Location = new System.Drawing.Point(411, 643);
            this.buttonHoroscopeResolve.Margin = new System.Windows.Forms.Padding(5);
            this.buttonHoroscopeResolve.Name = "buttonHoroscopeResolve";
            this.buttonHoroscopeResolve.Size = new System.Drawing.Size(537, 46);
            //this.buttonHoroscopeResolve.TabIndex = 2;
            this.buttonHoroscopeResolve.Location = new System.Drawing.Point(510, 48);
            this.buttonHoroscopeResolve.Text = "Click here to get your horoscope";
            this.buttonHoroscopeResolve.UseVisualStyleBackColor = true;
            this.buttonHoroscopeResolve.Click += new System.EventHandler(this.buttonHoroscopeResolve_Click);
            // 
            // pictureBoxHoroscope
            // 
            this.pictureBoxHoroscope.Image = global::A20_Ex01_Yaniv_204623268_Yogev_204542047.Properties.Resources.horoscopesLogo;
            //this.pictureBoxHoroscope.Location = new System.Drawing.Point(411, 130);
            this.pictureBoxHoroscope.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxHoroscope.Name = "pictureBoxHoroscope";
            //this.pictureBoxHoroscope.Size = new System.Drawing.Size(533, 465);
            this.pictureBoxHoroscope.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.pictureBoxHoroscope.TabIndex = 0;
            //this.pictureBoxHoroscope.TabStop = false;
            // 
            // HoroscopeForm
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            //this.ClientSize = new System.Drawing.Size(1356, 862);
            this.Controls.Add(this.buttonHoroscopeResolve);
            this.Controls.Add(this.labelHoroscopeTitle);
            this.Controls.Add(this.pictureBoxHoroscope);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            //this.MaximizeBox = false;
            //this.Name = "HoroscopeForm";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horoscope";
            //((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoroscope)).EndInit();
            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        private void fetchHoroscopeNameAndImage()
        {
            string dateOfBirth = FBAgent.LoggedInUser.Birthday;
            DateTime userDOB = DateTime.ParseExact(dateOfBirth, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            m_ZodiacName = HoroscopeAgent.GetZodiacName(userDOB);
            pictureBoxHoroscope.Image = HoroscopeAgent.GetZodiacImage(m_ZodiacName);
            labelHoroscopeTitle.Text = string.Format("You Are {0}!", m_ZodiacName.ToString());
        }

        private void locateAllControls()
        {
            // Move all the controls to the center
            this.labelHoroscopeTitle.Left = (this.Width) / 2 - (labelHoroscopeTitle.Width / 2);
        }

        private void buttonHoroscopeResolve_Click(object sender, EventArgs e)
        {
            fetchHoroscope();
        }

        private void fetchHoroscope()
        {
            this.pictureBoxHoroscope.Size = new Size(100, 100);
            pictureBoxHoroscope.Left = (this.Width) / 2 - (pictureBoxHoroscope.Width / 2);
            this.Controls.Remove(buttonHoroscopeResolve);
            initializeHoroscopeLabel();
        }

        private void initializeHoroscopeLabel()
        {
            Label horscopeText = new Label();

            horscopeText.Font = new Font("Levenim MT", 10);
            horscopeText.Height = 300;
            horscopeText.Width = this.Width - 50;
            horscopeText.Text = HoroscopeAgent.GetHoroscope(m_ZodiacName);
            horscopeText.Top = pictureBoxHoroscope.Bottom + 10;
            horscopeText.Left = (this.Width) / 2 - (horscopeText.Width / 2);
            this.Controls.Add(horscopeText);
        }
    }
}
