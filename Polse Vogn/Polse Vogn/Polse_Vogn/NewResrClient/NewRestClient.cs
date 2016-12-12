using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.Util;
using Newtonsoft.Json;


namespace Polse_Vogn.NewResrClient
{
    public class NewRestClient<PolseModel>
    {
        String TAG = "MyActivity";
        HttpClient client;


        private const string WebServiceUrl = "https://api.eniro.com/cs/proximity/basic?profile=rukantabula&key=9010769844804077008&country=dk&version=1.1.3&search_word=p%C3%B8lse&to_list=60&latitude=56.162939&longitude=10.203921000000037&max_distance=1000/";

        public async Task<List<PolseModel>> GetAsync()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            var uri = new Uri(string.Format(WebServiceUrl, string.Empty));

            var response = await client.GetAsync(uri);
           
            if (response.IsSuccessStatusCode)
            {
           var  content = await response.Content.ReadAsStringAsync();
                var taskModels = JsonConvert.DeserializeObject<List<PolseModel>>(content);

                return taskModels;

            }

            return null;

        }




    }
}
