using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RepetitionDemoHttpClient.Models
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
