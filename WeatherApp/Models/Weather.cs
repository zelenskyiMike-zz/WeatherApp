using System.Runtime.Serialization;

namespace WeatherApp.Models
{
    [DataContract]
    public class Weather
    {
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Icon { get; set; }
    }
}
