using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics
{
    internal class HoroscopeAgent
    {
        internal static string GetHoroscope(eZodiacs i_Zodiac)
        {
            string horoscope = null;
            string horoscopeURL = "http://horoscope-api.herokuapp.com/horoscope/today/" + i_Zodiac.ToString();
            string response = HttpGetRequest(horoscopeURL);
            horoscope = getHoroscopeText(response);

            return horoscope;
        }

        private static string getHoroscopeText(string i_HoroscopeResponse)
        {
            string horoscope = null;

            if (i_HoroscopeResponse != null)
            {
                Regex rx = new Regex(string.Format("\"horoscope\": \"(.*)?\","));
                Match m = rx.Match(i_HoroscopeResponse);
                if (m.Success)
                {
                    horoscope = m.Groups[1].ToString();
                }
            }

            return horoscope;
        }

        internal static eZodiacs GetZodiacName(DateTime i_DateOfBirth)
        {
            //Set defualt
            eZodiacs zodiac = eZodiacs.Capricorn;

            switch (i_DateOfBirth.Month)
            {
                case (int) Month.January: 
                    zodiac = (i_DateOfBirth.Day <= 19) ? eZodiacs.Capricorn : eZodiacs.Aquarius;
                    break;
                case (int) Month.February:
                    zodiac = (i_DateOfBirth.Day <= 18) ? eZodiacs.Aquarius : eZodiacs.Pisces;
                    break;
                case (int) Month.March:
                    zodiac = (i_DateOfBirth.Day <= 20) ? eZodiacs.Pisces : eZodiacs.Aries;
                    break;
                case (int) Month.April:
                    zodiac = (i_DateOfBirth.Day <= 20) ? eZodiacs.Aries : eZodiacs.Taurus;
                    break;
                case (int) Month.May:
                    zodiac = (i_DateOfBirth.Day <= 20) ? eZodiacs.Taurus : eZodiacs.Gemini;
                    break;
                case (int) Month.June:
                    zodiac = (i_DateOfBirth.Day <= 20) ? eZodiacs.Gemini : eZodiacs.Cancer;
                    break;
                case (int) Month.July:
                    zodiac = (i_DateOfBirth.Day <= 22) ? eZodiacs.Cancer : eZodiacs.Leo;
                    break;
                case (int) Month.August:
                    zodiac = (i_DateOfBirth.Day <= 22) ? eZodiacs.Leo : eZodiacs.Virgo;
                    break;
                case (int) Month.September:
                    zodiac = (i_DateOfBirth.Day <= 22) ? eZodiacs.Virgo : eZodiacs.Libra;
                    break;
                case (int) Month.October:
                    zodiac = (i_DateOfBirth.Day <= 22) ? eZodiacs.Libra : eZodiacs.Scorpio;
                    break;
                case (int) Month.November:
                    zodiac = (i_DateOfBirth.Day <= 21) ? eZodiacs.Scorpio : eZodiacs.Sagittarius;
                    break;
                case (int) Month.December:
                    zodiac = (i_DateOfBirth.Day <= 21) ? eZodiacs.Sagittarius : eZodiacs.Capricorn;
                    break;
            }

            return zodiac;
        }

        internal static Image GetZodiacImage(eZodiacs i_Zodiac)
        {
            Image image = null;
            
            switch (i_Zodiac)
            {
                case eZodiacs.Aquarius:
                    image = Properties.Resources.Aquarius_Astrology_Img;
                    break;
                case eZodiacs.Aries:
                    image = Properties.Resources.Aries_Astrology_Img;
                    break;
                case eZodiacs.Cancer:
                    image = Properties.Resources.Cancer_Astrology_Img;
                    break;
                case eZodiacs.Capricorn:
                    image = Properties.Resources.capricorn_Astrology_Img;
                    break;
                case eZodiacs.Gemini:
                    image = Properties.Resources.Gemini_Astrology_Img;
                    break;
                case eZodiacs.Leo:
                    image = Properties.Resources.Leo_Astrology_Img;
                    break;
                case eZodiacs.Libra:
                    image = Properties.Resources.Libra_Astrology_Img;
                    break;
                case eZodiacs.Pisces:
                    image = Properties.Resources.Pisces_Astrology_Img;
                    break;
                case eZodiacs.Sagittarius:
                    image = Properties.Resources.sagittarius_Astrology_Img;
                    break;
                case eZodiacs.Scorpio:
                    image = Properties.Resources.Scorpio_Astrology_Img;
                    break;
                case eZodiacs.Taurus:
                    image = Properties.Resources.Taurus_Astrology_Img;
                    break;
                case eZodiacs.Virgo:
                    image = Properties.Resources.Virgo_Astrology_Img;
                    break;

            }

            return image;
        }

        public static string HttpGetRequest(string i_URL)
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(i_URL);
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.  
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server. 
            // The using block ensures the stream is automatically closed. 
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Return the content.  
                return responseFromServer;
            }

            // Close the response.  
            response.Close();
        }
    }
}
