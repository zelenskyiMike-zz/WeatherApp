using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class RequestImageService : IRequestImageService
    {
        public async Task<byte[]> RequestByteArrayAsyc(string requestUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(requestUrl).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                return await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
              }
        }
    }
}
