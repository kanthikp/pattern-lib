using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.WeatherService
{
    public class WeatherServices
    {
        public Farenheit GetTempFarenheit(double latitude, double longitude)
        {
            return new Farenheit();
        }
        public class Farenheit
        {
            public double value;
            public Farenheit()
            {
                value = 130;
            }
            public string ToString(string s)
            {
                return value.ToString();
            }
        }
    }
}
