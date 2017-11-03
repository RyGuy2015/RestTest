using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace RestTest
{
    public static class CommunicationTest
    {
        // This uses HttpWebRequest to "GET" the data
        public static string GetTest (){

            var returnedMessage = "";
            var request = HttpWebRequest.Create(string.Format(@"https://jsonplaceholder.typicode.com/posts/1"));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    var content = reader.ReadToEnd();
                    if (string.IsNullOrWhiteSpace(content))
                    {
                        Console.Out.WriteLine("Response contained empty body...");
                    }
                    else
                    {
                        Console.Out.WriteLine("Response Body: \r\n {0}", content);
                        returnedMessage = content;
                    }

                }
            }

            return returnedMessage;
        }

        // This tests post but uses WebClient() instead of HttpWebRequest()
        // Just checking out different means to the same end
        public static byte[] WebClientPost()
        {
            byte[] returnedMessage;
            var url = "https://jsonplaceholder.typicode.com/posts";
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["username"] = "myUser";
                data["password"] = "myPassword";

                returnedMessage = wb.UploadValues(url, "POST", data);

            }
            Console.WriteLine(returnedMessage);
            return returnedMessage;
        }
    }
}
