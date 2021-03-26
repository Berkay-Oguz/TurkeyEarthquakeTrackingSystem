using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using TurkeyEarthquakeTrackingSystem.Entites;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;


namespace TurkeyEarthquakeTrackingSystem.API
{
    class ConnectManager
    {
        public List<Earthquake> earthquakes;
        internal void GetApiData()
        {
            var webRequest = WebRequest.Create("https://turkiyedepremapi.herokuapp.com/api") as HttpWebRequest;
            if (webRequest == null)
            {
                return;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    earthquakes = JsonConvert.DeserializeObject<List<Earthquake>>(contributorsAsJson);
                }
            }
        }

    }
}
