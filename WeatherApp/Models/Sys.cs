using System.Runtime.Serialization;

namespace WeatherApp.Models
{
    [DataContract]
    public class Sys
    {
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public int Sunrise { get; set; }
        [DataMember]
        public int Sunset { get; set; }
    }
}
