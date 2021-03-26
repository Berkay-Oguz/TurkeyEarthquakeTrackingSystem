using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkeyEarthquakeTrackingSystem.Entites
{
    class Earthquake
    {
        //public string id { get; set; }
        public string tarih { get; set; }
        public string saat { get; set; }
        public string enlem { get; set; }
        public string boylam { get; set; }
        public string derinlik { get; set; }
        public string buyukluk { get; set; }
        public string yer { get; set; }
        public string sehir { get; set; }
    }
}
