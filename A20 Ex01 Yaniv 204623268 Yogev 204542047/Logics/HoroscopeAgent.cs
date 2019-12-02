using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace A20_Ex01_Yaniv_204623268_Yogev_204542047.Logics
{
    class HoroscopeAgent
    {
        public static string GetHoroscope(eZodiacs i_Zodiac)
        {
            string horoscope = null;

            string url = "http://horoscope-api.herokuapp.com/horoscope/today/" + i_Zodiac.ToString();
            string response = HttpGetRequest(url);

            Regex rx = new Regex(string.Format("\"horoscope\": \"(.*)?\","));
            Match m = rx.Match(response);
            if(m.Success)
            {
                horoscope = m.Groups[1].ToString();
            }

            return horoscope;
        }

        public static eZodiacs GetZodiacName(DateTime i_DateOfBirth)
        {
            //Set defualt
            eZodiacs zodiac = eZodiacs.Capricorn;

            switch (i_DateOfBirth.Month)
            {
                case (int)Month.January:
                    if (i_DateOfBirth.Day <= 19)
                    {
                        zodiac = eZodiacs.Capricorn;
                    }
                    else
                    {
                        zodiac = eZodiacs.Aquarius;
                    }
                    break;
                case (int)Month.February:
                    if (i_DateOfBirth.Day <= 18)
                    {
                        zodiac = eZodiacs.Aquarius;
                    }
                    else
                    {
                        zodiac = eZodiacs.Pisces;
                    }
                    break;
                case (int)Month.March:
                    if (i_DateOfBirth.Day <= 20)
                    {
                        zodiac = eZodiacs.Pisces;
                    }
                    else
                    {
                        zodiac = eZodiacs.Aries;
                    }
                    break;
                case (int)Month.April:
                    if (i_DateOfBirth.Day <= 20)
                    {
                        zodiac = eZodiacs.Aries;
                    }
                    else
                    {
                        zodiac = eZodiacs.Taurus;
                    }
                    break;
                case (int)Month.May:
                    if (i_DateOfBirth.Day <= 20)
                    {
                        zodiac = eZodiacs.Taurus;
                    }
                    else
                    {
                        zodiac = eZodiacs.Gemini;
                    }
                    break;
                case (int)Month.June:
                    if (i_DateOfBirth.Day <= 20)
                    {
                        zodiac = eZodiacs.Gemini;
                    }
                    else
                    {
                        zodiac = eZodiacs.Cancer;
                    }
                    break;
                case (int)Month.July:
                    if (i_DateOfBirth.Day <= 22)
                    {
                        zodiac = eZodiacs.Cancer;
                    }
                    else
                    {
                        zodiac = eZodiacs.Leo;
                    }
                    break;
                case (int)Month.August:
                    if (i_DateOfBirth.Day <= 22)
                    {
                        zodiac = eZodiacs.Leo;
                    }
                    else
                    {
                        zodiac = eZodiacs.Virgo;
                    }
                    break;
                case (int)Month.September:
                    if (i_DateOfBirth.Day <= 22)
                    {
                        zodiac = eZodiacs.Virgo;
                    }
                    else
                    {
                        zodiac = eZodiacs.Libra;
                    }
                    break;
                case (int)Month.October:
                    if (i_DateOfBirth.Day <= 22)
                    {
                        zodiac = eZodiacs.Libra;
                    }
                    else
                    {
                        zodiac = eZodiacs.Scorpio;
                    }
                    break;
                case (int)Month.November:
                    if (i_DateOfBirth.Day <= 21)
                    {
                        zodiac = eZodiacs.Scorpio;
                    }
                    else
                    {
                        zodiac = eZodiacs.Sagittarius;
                    }
                    break;
                case (int)Month.December:
                    if (i_DateOfBirth.Day <= 21)
                    {
                        zodiac = eZodiacs.Sagittarius;
                    }
                    else
                    {
                        zodiac = eZodiacs.Capricorn;
                    }
                    break;
            }

            return zodiac;
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
