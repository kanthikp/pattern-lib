using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.WeatherService;

namespace Facade.Pattern._1
{
    class Program
    {
        // before facade pattern
        static void Main(string[] args)
        {
            const string zipCode = "45632";

            GeoLookupService geoLookupService = new GeoLookupService();

            var city = geoLookupService.GetCityFromZipCode(zipCode);
            var state = geoLookupService.GetStateFromZipCode(zipCode);
            var coords = geoLookupService.GetCoordinatesFromZipCode(zipCode);

            WeatherServices weatherService = new WeatherServices();
            var farenheit = weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);

            EnglishMetricConverter englishMetricConverter = new EnglishMetricConverter();
            var celcius = englishMetricConverter.FarenheitToCelcious(farenheit);

            Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}",

                                farenheit.ToString("F1"),
                                celcius.ToString("F1"),
                                city,
                                state);
        }
    }
}
