using Microsoft.AspNetCore.Mvc;
using Nackowskis.Models;
using Nackowskis.Models.AuctionViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nackowskis.DataLayer
{
    public interface IAdminRepository
    {
        List<AuctionModel> GetAllAuctions();

        void CreateAuction();

        void DeleteAuction(int id);

        void UpdateAuction(int id);

        void MakeBid();
    }
}
