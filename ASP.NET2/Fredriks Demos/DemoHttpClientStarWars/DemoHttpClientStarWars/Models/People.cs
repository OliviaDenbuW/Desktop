using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace DemoHttpClientStarWars.Models
{
    //Gå in på http://json2csharp.com/ 
    //och generera upp dennna klass utifrån utseendet på json responsen

    [DataContract]
    public class People
    {
        //Här ändrar vi namnet på värdet internt 
        //och mappar med hur det ser ut i json responsen
        [DataMember(Name = "name")]
        public string Name { get; set; }       

        [DataMember (Name="height")]
        public string Height { get; set; }


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
