using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace OliviaDemoHttpClient.Models
{
    //Attribut som läggs på för serialisering
    [DataContract]
    public class Person
    {
        //Attribut som läggs på för serialisering
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
