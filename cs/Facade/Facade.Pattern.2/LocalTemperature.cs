using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.WeatherService;

namespace Facade.Pattern._2
{
    public class LocalTemperature
    {
        public WeatherService.WeatherServices.Farenheit Farenheit { get; set; }
        public string City { get; set; }
        public EnglishMetricConverter.Celcius Celcius { get; set; }
        public object State { get; set; }
    }
}
