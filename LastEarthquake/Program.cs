using System;
using System.Net;

namespace LastEarthquake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PullData(string url, string tag)
            {
                var startTag = "<" + tag + ">";
                int startIndex = url.IndexOf(startTag) + startTag.Length;
                int endIndex = url.IndexOf("</" + tag + ">", startIndex);
                return url.Substring(startIndex, endIndex - startIndex);
            }

            string bounUrl;
            using (WebClient client = new WebClient())
                bounUrl = client.DownloadString("http://www.koeri.boun.edu.tr/scripts/lst4.asp");
            

            string result = PullData(bounUrl, "pre");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
