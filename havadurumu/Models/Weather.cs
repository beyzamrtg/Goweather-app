using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace havadurumu.Models
{
    class CityWeather
    {
        public string Temperature { get; set; }
        public string Wind { get; set; }
        public string Description { get; set; }
        public Forecast[] Forecast { get; set; }
    }

    class Forecast
    {
        
        public string Day { get; set; }
        public string Temperature { get; set; }
        public string Wind { get; set; }
    }
}
