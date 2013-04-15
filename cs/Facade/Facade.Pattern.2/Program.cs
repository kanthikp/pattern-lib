using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Pattern._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string zipCode = "45632";

            var temperatureFacade = new TemperatureLookupFacade();
            var localTemp = temperatureFacade.GetTemperature(zipCode);

            Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}",
                                localTemp.Farenheit.ToString("F1"),
                                localTemp.Celcius.ToString("F1"),
                                localTemp.City,
                                localTemp.State);

        }
    }
}
