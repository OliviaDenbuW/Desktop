using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nackowskis.DataLayer;
using Nackowskis.Models;
using Nackowskis.Models.AuctionViewModels;

namespace Nackowskis.BusinessLayer
{
    public class AdminBusiness : IAdminBusiness
    {
        private IAdminRepository _repository;

        public AdminBusiness(IAdminRepository repository)
        {
            _repository = repository;
        }

        public List<AuctionModel> GetAllAuctions()
        {
            return _repository.GetAllAuctions();
        }

        public void CreateAuction()
        {
            _repository.CreateAuction();
        }

        public void DeleteAuction(int id)
        {
            _repository.DeleteAuction(id);
        }

        Task<List<AuctionViewModel>> IAdminBusiness.GetAllAuctions()
        {
            throw new NotImplementedException();
        }

        Task IAdminBusiness.CreateAuction()
        {
            throw new NotImplementedException();
        }

        Task IAdminBusiness.DeleteAuction(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAuction(int id)
        {
            throw new NotImplementedException();
        }

        public Task MakeBid()
        {
            throw new NotImplementedException();
        }
    }
}
