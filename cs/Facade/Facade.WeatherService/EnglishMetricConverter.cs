using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.WeatherService
{
    public class EnglishMetricConverter
    {
        public static Celcius  FarenheitToCelcious(object farenheit)
        {
            throw new NotImplementedException();
        }
        public class Celcius
        {
            public double value;
            public Celcius() 
            {
                value = 0;
            }
            public string ToString(string v)
            {
                return value.ToString();
            }
        }
    }
}
