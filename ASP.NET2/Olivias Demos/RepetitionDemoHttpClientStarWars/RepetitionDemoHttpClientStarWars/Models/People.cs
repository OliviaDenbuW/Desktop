using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RepetitionDemoHttpClientStarWars.Models
{
    [DataContract]
    public class People
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string height { get; set; }

        [DataMember]
        public string mass { get; set; }

        [DataMember]
        public string hair_color { get; set; }

        [DataMember]
        public string skin_color { get; set; }

        [DataMember]
        public string eye_color { get; set; }

        [DataMember]
        public string birth_year { get; set; }

        [DataMember]
        public string gender { get; set; }

        [DataMember]
        public string homeworld { get; set; }

        public List<string> films { get; set; }
        public List<string> species { get; set; }
        public List<string> vehicles { get; set; }
        public List<string> starships { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }
}
