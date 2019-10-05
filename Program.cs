using System;
using System.IO;
using System.Net;
using System.Text;

namespace Examples.System.Net
{
  public class WebRequestGetExample
  {
    public static void Main()
    {
      // Create a request for the URL. 		
      WebRequest request = WebRequest.Create("https://api.unsplash.com/photos");
      request.Headers.Add("Authorization", "Client-ID a43c3e64f885a5c06277e2508ad66961ba50161b989c6c8f2c97cf6634b7eff7");
      // If required by the server, set the credentials.
      // request.Credentials = CredentialCache.DefaultCredentials;
      // Get the response.
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();
      // Display the status.
      Console.WriteLine(response.StatusDescription);
      // Get the stream containing content returned by the server.
      Stream dataStream = response.GetResponseStream();
      // Open the stream using a StreamReader for easy access.
      StreamReader reader = new StreamReader(dataStream);
      // Read the content.
      string responseFromServer = reader.ReadToEnd();
      // Display the content.
      Console.WriteLine(responseFromServer);
      // Cleanup the streams and the response.
      reader.Close();
      dataStream.Close();
      response.Close();

      // convert the json string (responseFromServer) into a C# POCO (plain old C# Object)
      // loop over that object, foreach image 
      // do a webrequest to get the lat/long

    }
  }
}
