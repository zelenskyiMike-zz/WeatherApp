using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WeatherApp.Models
{
    [DataContract]
    public class City
    {
        [DataMember]
        public string Name { get; set; }
    }
}
