using System.Collections.Generic;
using System.Windows.Forms;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.UI
{
    internal class EventsTabPage : TabPage
    {
        List<EventComponent> EventList;

        public EventsTabPage(string i_TabText) : base(i_TabText)
        {
            initializeComponent();
            fetchEvents();         
        }

        private void fetchEvents()
        {
            EventList = getDummyData();

            for (int i = 0; i < EventList.Count && i < 6; i++)
            {
                this.Controls.Add(EventList[i]);
            }
        }

        private void initializeComponent()
        {
            this.Width = AppSettings.Instance.MainWindowWidth;
            this.Height = AppSettings.Instance.MainWindowHeight;
            this.AutoScroll = true;
        }

        private List<EventComponent> getDummyData()
        {
            List<EventComponent> events = new List<EventComponent>(); 
            EventComponent eventComponent1 = new EventComponent();
            EventComponent eventComponent2 = new EventComponent();
            EventComponent eventComponent3 = new EventComponent();
            int position = 60;

            createEventDummyData(ref eventComponent1, "2020 celebrations", "IDC", "01/01/20",
                "00:00", "03:00", position);
            position = eventComponent1.Bottom + 20;
            ControlsUtils.CenteringControl(eventComponent1);

            createEventDummyData(ref eventComponent2, "Omer Adam Show", "Keisariya", "18/01/20",
                "20:00", "22:00", position);
            position = eventComponent2.Bottom + 20;
            ControlsUtils.CenteringControl(eventComponent2);

            createEventDummyData(ref eventComponent3, "Yogev Wedding", "Mikonos", "?/?/?",
                "20:00", "05:00", position);
            ControlsUtils.CenteringControl(eventComponent3);
            
            events.Add(eventComponent1);
            events.Add(eventComponent2);
            events.Add(eventComponent3);

            return events;
        }

        private static void createEventDummyData(ref EventComponent i_Event, string i_EventName,
            string i_Location, string i_Date, string i_Start, string i_End, int i_Position)
        {
            i_Event.labelEventName.Text = string.Format("{0}", i_EventName);
            i_Event.labelEventLocation.Text = string.Format("{0}{1}", "Location: ", i_Location);
            i_Event.labelEventDate.Text = string.Format("{0}{1}", "Date: ", i_Date);
            i_Event.labelEventStartt.Text = string.Format("{0}{1}", "Starts at: ", i_Start);
            i_Event.labelEventEnd.Text = string.Format("{0}{1}", "Ends at: ", i_End);
            i_Event.Top = i_Position;
        }
    }
}
