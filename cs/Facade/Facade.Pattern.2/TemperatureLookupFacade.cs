using Facade.WeatherService;

namespace Facade.Pattern._2
{
    public class TemperatureLookupFacade
    {
        readonly WeatherServices weatherServices;
        readonly GeoLookupService geoLookupService;
        readonly EnglishMetricConverter converter;

        public TemperatureLookupFacade()
            : this(new WeatherServices(), new GeoLookupService(), new EnglishMetricConverter())
        { }
        public TemperatureLookupFacade(WeatherServices ws, GeoLookupService gls, EnglishMetricConverter cnv)
        {
            weatherServices = ws;
            geoLookupService = gls;
            converter = cnv;
        }
        public LocalTemperature GetTemperature(string zipcode)
        {
            var coords = geoLookupService.GetCoordinatesFromZipCode(zipcode);
            var city = geoLookupService.GetCityFromZipCode(zipcode);
            var state = geoLookupService.GetStateFromZipCode(zipcode);

            var farenheit = weatherServices.GetTempFarenheit(coords.Latitude, coords.Longitude);
            var celcius = converter.FarenheitToCelcious(farenheit);

            var localTemperature = new LocalTemperature()
                                    {
                                        Farenheit  = farenheit,
                                        Celcius = celcius,
                                        City = city,
                                        State = state
                                    };
            return localTemperature;
        }       
    }
}
