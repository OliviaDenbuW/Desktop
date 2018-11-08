using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Nackowskis.Models
{
    [DataContract]
    public class AuctionModel
    {
        [DataMember]
        public int AuktionID { get; set; }
        [DataMember]
        public string Titel { get; set; }
        [DataMember]
        public string Beskrivning { get; set; }

        [DataMember]
        public string StartDatumString { get; set; }

        public DateTime StartDatum { get; set; }


        //"AuktionID": 2568,
        //"Titel": "Hello Olivia",
        //"Beskrivning": "ar snall",
        //"StartDatum": "2018-07-25T00:00:00",
        //"SlutDatum": "2018-09-24T00:00:00",
        //"Gruppkod": 1080,
        //"Utropspris": 1000,
        //"SkapadAv": "Alexito"
    }
}
