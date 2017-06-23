using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Linq;
using XamarinFinal;

public static class Geocoding
{

    

    public static string GetMatrix(string origins, string destinations)
    {
 
        var requestUri =("https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + Uri.EscapeDataString(origins)+"&destinations="+ Uri.EscapeDataString(destinations)+ "&key="+ ApiKey.Key);

     

        var request = WebRequest.Create(requestUri);
        var rep = request.GetResponse();
        var xdoc = XDocument.Load(rep.GetResponseStream());

        var result = xdoc.Element("DistanceMatrixResponse").Element("row");
        var locationElement = result.Element("element");
        var t = locationElement.Element("distance");
          return (string)t.Element("text");
       }


    //maps.googleapis.com/maps/api/geocode/json?address=1600+Amphitheatre+Parkway,+Mountain+View,+CA&key=YOUR_API_KEY


    public static LatLon GetLatLon(string origins)
    {
var r=        new LatLon();

        var requestUri = ("https://maps.googleapis.com/maps/api/geocode/xml?address="+ Uri.EscapeDataString(origins) + "&key="+ ApiKey.Key);
        
        var request = WebRequest.Create(requestUri);
        var response = request.GetResponse();
        var xdoc = XDocument.Load(response.GetResponseStream());

        var result = xdoc.Element("GeocodeResponse").Element("result");
        var locationElement = result.Element("geometry").Element("location");
        var lat = locationElement.Element("lat");
        var lng = locationElement.Element("lng");
        r.lat = (double)lat;
        r.lon = (double)lng;
        return r;
    }


    /// <summary>
    /// Méthode pour envoyer la requête http
    /// </summary>
    /// <param name="uri"></param>
    /// <returns></returns>
    private static string GetRequest(Uri uri)
    {
        string answer = string.Empty;

        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
        using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
        {
            if (req.HaveResponse && res.StatusCode == HttpStatusCode.OK)
                using (Stream resin = res.GetResponseStream())
                {
                    using (StreamReader rea = new StreamReader(resin))
                    {
                        answer = rea.ReadToEnd();
                    }
                }
        }

        return answer;
    }



}

