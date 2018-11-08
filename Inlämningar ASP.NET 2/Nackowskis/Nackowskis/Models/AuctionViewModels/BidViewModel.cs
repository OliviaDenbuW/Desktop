using Nackowskis.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Nackowskis.Models.AuctionViewModels
{
    [DataContract]
    public class BidViewModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int AuctionId { get; set; }

        [DataMember]
        public BidderViewModel Bidder { get; set; }
    }
}
