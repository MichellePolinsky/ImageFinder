using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using GetAPhoto;
using GetAllPhotos;
using System.Linq;


namespace Examples.System.Net
{
  public class WebRequestGetExample
  {


    public static void Main()
    {
      // Create a request for the URL. 		
      WebRequest request = WebRequest.Create("https://api.unsplash.com/photos?per_page=30&page=2");
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
      // Console.WriteLine(responseFromServer);
      // Cleanup the streams and the response.
      reader.Close();
      dataStream.Close();
      response.Close();

      // convert the json string (responseFromServer) into a C# POCO (plain old C# Object)
      var allPhotos = JsonConvert.DeserializeObject<GetAllPhoto[]>(responseFromServer);
      // loop over that object, foreach image
      var count = 1;
      foreach (var photo in allPhotos)
      {
        Console.WriteLine(count);
        count++;
        // do a webrequest to get the lat/long
        WebRequest single = WebRequest.Create("https://api.unsplash.com/photos/" + photo.id);
        single.Headers.Add("Authorization", "Client-ID a43c3e64f885a5c06277e2508ad66961ba50161b989c6c8f2c97cf6634b7eff7");
        // If required by the server, set the credentials.
        // request.Credentials = CredentialCache.DefaultCredentials;
        // Get the response.
        HttpWebResponse resp = (HttpWebResponse)single.GetResponse();
        // Display the status.
        Console.WriteLine(resp.StatusDescription);
        // Get the stream containing content returned by the server.
        Stream ds = resp.GetResponseStream();
        // Open the stream using a StreamReader for easy access.
        StreamReader rdr = new StreamReader(ds);
        // Read the content.
        string respData = rdr.ReadToEnd();
        // Console.WriteLine(respData);
        // Display the content.
        var thisPhoto = JsonConvert.DeserializeObject<APhoto>(respData);
        Console.WriteLine($"{thisPhoto.id} | lat: {thisPhoto.location.position.latitude} | lng: {thisPhoto.location.position.longitude} | city: {thisPhoto.location.city}");
        // Cleanup the streams and the response.
        reader.Close();
        dataStream.Close();
        response.Close();


        // if (thisPhoto has a lat/lng)

        if (thisPhoto.location.position.latitude != null && thisPhoto.location.position.longitude != null)
        {
          Console.WriteLine("found one.");
        }



        // POST that photo to your own localhost:5001/api/CreatePhoto
      }


    }

  }
}
