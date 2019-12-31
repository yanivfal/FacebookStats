using System.Windows.Forms;
using A20_Ex01_Yaniv_204623268_Yogev_204542047.Proxy;
using FacebookWrapper.ObjectModel;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047
{
    public partial class WallPhoto : UserControl
    {
        private PictureBoxProxy m_Photo;

        public WallPhoto(Photo i_Photo)
        {
            m_Photo = new PictureBoxProxy(i_Photo, 400);
            InitializeComponent();
            initializePhotoProperties(i_Photo);
            setPictureDetails(i_Photo);
        }

        private void initializePhotoProperties(Photo i_Photo)
        {
            m_Photo.Left = this.Left;
            m_Photo.Top = DateIcon.Bottom + 5;
            this.Width = m_Photo.Width;
            this.Height = m_Photo.Height + 100;

            this.Controls.Add(m_Photo);
        }

        private void setPictureDetails(Photo i_Photo)
        {
            //Insert dummy data
            labelDate.Text = i_Photo.CreatedTime.Value.ToString("MMMM dd");
            //labelLikes.Text = i_Photo.LikedBy.Count().ToString
            labelLikes.Text = "267";
            //labelLikes.Text = i_Photo.LikedBy.Count().ToString
            labelLocation.Text = "IDC, Herzeliya";
        }
    }
}