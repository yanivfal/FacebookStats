using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public class AppSettings
    {
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        public readonly int m_WindowWidth;
        public readonly int m_ScrollWindowHeight;
        public readonly int m_RegularWindowHeight;

        public static AppSettings Instance = new AppSettings();
        private AppSettings()
        {          
            RememberUser = false;
            LastAccessToken = null;
            m_WindowWidth = 960;
            m_ScrollWindowHeight = 2000;
            m_RegularWindowHeight = 960;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"appSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }

        public static void LoadFile()
        {
            string xmlPath = @"appSettings.xml";

            try
            {
                if (File.Exists(xmlPath))
                {
                    using (Stream stream = new FileStream(xmlPath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                        Instance = serializer.Deserialize(stream) as AppSettings;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
