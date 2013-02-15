//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all
//exceptions and to free any used resources in the finally block.


using System;
using System.Net;
using System.IO;

class DownlaodFile
{
    static void Main()
    {
        using(WebClient client=new WebClient())
            try
            {
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "image.jpg");

            }
            catch (WebException)
            {
                Console.WriteLine("Invalid address");
            }
    }
}

