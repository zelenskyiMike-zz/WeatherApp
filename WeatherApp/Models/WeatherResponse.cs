using System.Collections.Generic;
using System.Runtime.Serialization;
using AppKit;

namespace WeatherApp.Models
{
    [DataContract]
    public class WeatherResponse
    {
        [DataMember]
        public IList<Weather> Weather { get; set; }
        [DataMember]
        public Main Main { get; set; }
        [DataMember]
        public Wind Wind { get; set; }
        [DataMember]
        public Sys Sys { get; set; }
        public NSImage ImageDownloaded { get; set; }
    }
}
