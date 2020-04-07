using System.Runtime.Serialization;

namespace WeatherApp.Models
{
    [DataContract]
    public class Wind
    {
        [DataMember]
        public double Speed { get; set; }
    }
}
