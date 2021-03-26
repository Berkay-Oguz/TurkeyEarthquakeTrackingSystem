using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkeyEarthquakeTrackingSystem.Abstract;
using TurkeyEarthquakeTrackingSystem.API;

namespace TurkeyEarthquakeTrackingSystem.Concrete
{
    public class MarkersAddService : IMarker
    {
        public GMapOverlay markers = new GMapOverlay("markers");
        public void GetMarkers()
        {
            ConnectManager connectManager = new ConnectManager();
            connectManager.GetApiData();
            foreach (var earthquake in connectManager.earthquakes)
            {
                double enlem = Convert.ToDouble(earthquake.enlem);
                double boylam = Convert.ToDouble(earthquake.boylam);
                GMapMarker marker2 = new GMarkerGoogle(
                   new PointLatLng(enlem, boylam),
                   GMarkerGoogleType.red);
                markers.Markers.Add(marker2);
            }
        }
    }
}
