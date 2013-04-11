using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.WeatherService
{
    public class GeoLookupService
    {
        public object GetCityFromZipCode(string zipCode)
        {
            throw new NotImplementedException();
        }

        public object GetStateFromZipCode(string zipCode)
        {
            throw new NotImplementedException();
        }

        public Coord GetCoordinatesFromZipCode(string zipCode)
        {
            return new Coord();
        }
        public class Coord
        {
            public double Latitude = 0;
            public double Longitude = 0;
        }
    }
}
