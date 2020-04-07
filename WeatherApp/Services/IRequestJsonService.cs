using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public interface IRequestJsonService
    {
        Task<string> RequestJsonAsync(string requestUrl);
        Task<string> RequestLocalJson(string path);
    }
}
