using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                double enlem;
                double boylam;
                double.TryParse(earthquake.enlem, NumberStyles.Any, CultureInfo.InvariantCulture, out enlem);
                double.TryParse(earthquake.boylam, NumberStyles.Any, CultureInfo.InvariantCulture, out boylam);
                GMapMarker marker2 = new GMarkerGoogle(
                   new PointLatLng(enlem, boylam),
                   GMarkerGoogleType.red);
                markers.Markers.Add(marker2);
            }
        }
    }
}
