using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MccoysStoreApp.Models
{
    public class Store
    {
        public int StoreNumber { get; set; }
        public string StoreName { get; set; }
        public string StoreManagerName { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
    }

}
