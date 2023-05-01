using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCategory.Models
{
    public class ProductDetail
    {

        public int Id { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public int Mrp { get; set; }
        public int Tax { get; set; }
        public string TaxType { get; set; }
        public bool IsActive { get; set; }

        
    }
}