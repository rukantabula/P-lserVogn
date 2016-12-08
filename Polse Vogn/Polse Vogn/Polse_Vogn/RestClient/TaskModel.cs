using Polse_Vogn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.RestClient
{
    /// <summary>
    /// Sample model to test the RestClient object 
    /// with the web service available on:
    /// http://taskmodel.azurewebsites.net/api/TaskModels/
    /// </summary>
    public class TaskModel
    {

        public string eniroId { get; set; }
        public CompanyInfo companyInfo { get; set; }
        public Address address { get; set; }
        public Location location { get; set; }
        public List<object> phoneNumbers { get; set; }
        public string companyReviews { get; set; }
        public string homepage { get; set; }
        public object facebook { get; set; }
        public string infoPageLink { get; set; }
    }
}

