using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using TurkeyEarthquakeTrackingSystem.API;
using TurkeyEarthquakeTrackingSystem.Concrete;

namespace TurkeyEarthquakeTrackingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectManager connectManager = new ConnectManager();
            MarkersAddService markers = new MarkersAddService();

            EarthquakeMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            EarthquakeMap.Position = new GMap.NET.PointLatLng(39.1432984, 35.3912303);
            EarthquakeMap.ShowCenter = false;

            markers.GetMarkers();
            connectManager.GetApiData();
            EarthquakeMap.Overlays.Add(markers.markers);
        }
    }
}
