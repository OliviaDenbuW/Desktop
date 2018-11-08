using Nackowskis.Models.AuctionViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowskis.BusinessLayer
{
    public interface IAdminBusiness
    {
        Task<List<AuctionViewModel>> GetAllAuctions();

        Task CreateAuction();

        Task DeleteAuction(int id);

        Task UpdateAuction(int id);

        Task MakeBid();
    }
}
