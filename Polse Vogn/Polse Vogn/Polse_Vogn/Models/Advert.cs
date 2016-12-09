using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Polse_Vogn.Models
{
    public class Advert
    {
        [JsonProperty("eniroId")]
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

    public class Address
    {
        public string streetName { get; set; }
        public string postCode { get; set; }
        public string postArea { get; set; }
        public object postBox { get; set; }
        public string coName { get; set; }
    }

    public class CompanyInfo
    {
        public string companyName { get; set; }
        public string orgNumber { get; set; }
        public string cvrPNumber { get; set; }
        public object companyText { get; set; }
    }

    public class Coordinate
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string use { get; set; }
    }

    public class Location
    {
        public List<Coordinate> coordinates { get; set; }
    }

    public class RootObject
    {
        public string title { get; set; }
        public string query { get; set; }
        public int totalHits { get; set; }
        public int totalCount { get; set; }
        public int startIndex { get; set; }
        public int itemsPerPage { get; set; }
        public List<Advert> adverts { get; set; }
    }
}

