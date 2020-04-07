using AppKit;
using Foundation;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService : IWeatherService
    {
        IRequestJsonService requestJsonService;
        IRequestImageService requestImageService;

        const string queryEndpoint = "https://api.openweathermap.org/data/2.5/weather?q={0}&appId={1}&units=metric";
        const string queryIconEndpoint = "https://openweathermap.org/img/w/{0}.png";
        const string appId = "e22c9d814c635926066854f385a5ef42";
   
        public async Task<WeatherResponse> GetWeatherResponse(string cityName)
        {
            requestJsonService = new RequestJsonService();
            requestImageService = new RequestImageService();

            var requestUrl = string.Format(queryEndpoint, cityName, appId);
            var json = await requestJsonService.RequestJsonAsync(requestUrl).ConfigureAwait(false);
            if (string.IsNullOrEmpty(json))
            {
                return new WeatherResponse();
            }
            var weather = JsonConvert.DeserializeObject<WeatherResponse>(json);

            var requestIconUrl = string.Format(queryIconEndpoint, weather.Weather.First().Icon);
            var responseByteArray = await requestImageService.RequestByteArrayAsyc(requestIconUrl).ConfigureAwait(false);

            if (responseByteArray != null)
            {

                NSData nsdata = NSData.FromArray(responseByteArray);
                NSImage image = new NSImage(nsdata);

                weather.ImageDownloaded = image;
            }

            return weather;
        }
    }
}
