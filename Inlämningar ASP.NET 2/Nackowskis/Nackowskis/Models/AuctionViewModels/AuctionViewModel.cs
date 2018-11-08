using Nackowskis.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Nackowskis.Models.AuctionViewModels
{
    [DataContract]
    public class AuctionViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string StartDate { get; set; }

        [DataMember]
        public string EndDate { get; set; }

        [DataMember]
        public int GroupCode { get; set; }

        [DataMember]
        public decimal StartPrice { get; set; }

        [DataMember]
        public AdminViewModel CreatedBy { get; set; }

        public DateTime StartDateVM { get; set; }
        public DateTime EndDateVM { get; set; }
    }
}
