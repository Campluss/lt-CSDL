using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phatnguyen.Model
{
    public class ProductInfo
    { 
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Size { get; set; }
        public string Corlor { get; set; }
        public int? Amount { get; set; }
        public string ProductType { get; set; }
        public double? Price { get; set; }
    }
}
