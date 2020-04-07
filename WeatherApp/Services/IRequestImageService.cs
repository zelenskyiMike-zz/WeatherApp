using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public interface IRequestImageService
    {
        Task<byte[]> RequestByteArrayAsyc(string requestUrl);
    }
}
