using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class RequestJsonService : IRequestJsonService
    {
        public async Task<string> RequestJsonAsync(string requestUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await  client.GetAsync(requestUrl).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    return string.Empty;
                }
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        public async Task<string> RequestLocalJson(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync().ConfigureAwait(false);
            }
        }
    }
}
