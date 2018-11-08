using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nackowskis.Data;
using Nackowskis.Models;
using Nackowskis.Models.AuctionViewModels;

namespace Nackowskis.DataLayer
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _context;
        private Uri baseAdressAuction;
        private Uri baseAdressBid;
        private string _apiKey;

        public AdminRepository(IConfiguration config, ApplicationDbContext context)
        {
            _apiKey = "1080";
            _context = context;
            baseAdressAuction = new Uri ("http://nackowskis.azurewebsites.net/api/Auktion/");
        }

        public List<AuctionModel> GetAllAuctions()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = baseAdressAuction;
                client.DefaultRequestHeaders.Accept.Clear();
                //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                //
               
              

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<AuctionModel>));
                HttpResponseMessage response = client.GetAsync(_apiKey).Result;
                response.EnsureSuccessStatusCode();
                //Tar emot en stream som skall serialiseras
                Stream responseStream = response.Content.ReadAsStreamAsync().Result;
                //Omvandlar den response stream som tagit emot till ett Person objekt
                List<AuctionModel> model = (List<AuctionModel>)serializer.ReadObject(responseStream);
                return model;
            }
            
            
        }

        public void CreateAuction()
        {
            throw new NotImplementedException();
        }

        public void DeleteAuction(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuction(int id)
        {
            throw new NotImplementedException();
        }

        public void MakeBid()
        {
            throw new NotImplementedException();
        }

        //public void VetEj()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        //Basadress till web api:et
        //        client.BaseAddress = new System.Uri("http://nackowskis.azurewebsites.net");

        //        //Skicka anropet och ta emot
        //        HttpResponseMessage response = client.GetAsync("/api/Auktion/1080").Result;

        //        //Skapa en serializer för att omvandla json till ett People objekt
        //        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(AuctionViewModel));

        //        //Läs över i en stream
        //        System.IO.Stream responseStream = response.Content.ReadAsStreamAsync().Result;

        //        //Läs över till ett people objekt
        //        AuctionViewModel model = (AuctionViewModel)serializer.ReadObject(responseStream);

        //        return model;
        //    }
        //}
    }
}
