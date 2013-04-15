using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.WeatherService
{
    public class GeoLookupService
    {
        public string GetCityFromZipCode(string zipCode)
        {
            return "Paris";
        }

        public object GetStateFromZipCode(string zipCode)
        {
            return "IDF";
        }

        public Coord GetCoordinatesFromZipCode(string zipCode)
        {
            return new Coord();
        }
        public class Coord
        {
            public double Latitude = 98;
            public double Longitude = 25;
        }
    }
}
