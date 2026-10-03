using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    internal class Brands
    {
    }
    class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Country { get; set; }
    
        public Brand()
        {
            this.BrandID = 0;
            this.BrandName = "N/A";
            this.Country = "N/A";
        }
        public Brand(int brandid, string brandname, string country)
        {
            this.BrandID = brandid;
            this.BrandName = brandname;
            this.Country = country;
        }
    }
}
