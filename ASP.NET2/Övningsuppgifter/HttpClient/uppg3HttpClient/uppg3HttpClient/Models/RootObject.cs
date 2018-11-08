using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace uppg3HttpClient.Models
{
    [DataContract]
    public class RootObject
    {
        [DataMember]
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }

        [DataMember]
        public List<Movies> results { get; set; }
    }
}
