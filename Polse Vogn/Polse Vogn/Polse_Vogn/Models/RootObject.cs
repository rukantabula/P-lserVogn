using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polse_Vogn.Models
{
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
