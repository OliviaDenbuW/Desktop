using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace uppg3HttpClient.Models
{
    [DataContract]
    public class Movies
    {
        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string director { get; set; }

        [DataMember]
        public string release_date { get; set; }

    }
}
