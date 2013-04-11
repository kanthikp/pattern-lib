using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.WeatherService
{
    public class WeatherServices
    {
        public static Farenheit GetTempFarenheit(double latitude, double longitude)
        {
            throw new NotImplementedException();
        }
        public class Farenheit
        {
            public double value;
            public Farenheit()
            {
                value = 0;
            }
            public string ToString(string s)
            {
                return value.ToString();
            }
        }
    }
}
