using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.WeatherService
{
    public class EnglishMetricConverter
    {
        public Celcius  FarenheitToCelcious(object farenheit)
        {
            return new Celcius();
        }
        public class Celcius
        {
            public double value;
            public Celcius() 
            {
                value = 21;
            }
            public string ToString(string v)
            {
                return value.ToString();
            }
        }
    }
}
