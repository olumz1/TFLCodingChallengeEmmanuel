using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace TFLCodingChallengeEmmanuel.Console
{
    class Program
    {
        static int Main(string[] args)
        {
            var roadId = System.Console.ReadLine();

            var response = CallRoadStatusMethod(roadId);

            return response;
        }

        public static int CallRoadStatusMethod(string roadId)
        {
            var baseUrl = $"https://localhost:44380/Road/{roadId}";
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(baseUrl);
            webRequest.Method = "GET";
            try
            {
                using HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                var dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                var result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                System.Console.Write(result);
                return Environment.ExitCode = (int)ExitCodeEnum.Success;
            }
            catch (Exception e)
            {
                System.Console.Write($"{roadId} is not a valid road");
                return Environment.ExitCode = (int)ExitCodeEnum.Invalid;
            }

        }
    }
}
