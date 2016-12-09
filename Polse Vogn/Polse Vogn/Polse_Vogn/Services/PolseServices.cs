using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.RestClient;
using Polse_Vogn.Models;

namespace Polse_Vogn.Services
{
    public class PolseServices
    {
        public async Task<List<Advert>> GetPolseAsync()
        {
            RestClient<Advert> restClient = new RestClient<Advert>();

            var AdvertList = await restClient.GetAsync();
            return AdvertList;
        }
    }
}