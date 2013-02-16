using System;
using System.Net;

public class Download
{
    public static void Main()
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The internet address you entered is invalid.");
            }
        }
    }
}