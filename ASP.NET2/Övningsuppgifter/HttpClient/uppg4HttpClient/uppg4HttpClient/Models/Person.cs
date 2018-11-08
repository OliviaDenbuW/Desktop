using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace uppg4HttpClient.Models
{
    [DataContract]
    public class Person
    {
        
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string height { get; set; }

        [DataMember]
        public string mass { get; set; }

        [DataMember]
        public string hair_color { get; set; }
    }
}
