using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf
{
    public enum ProductCategories
    {
        Food,
        Appliances
    }
    public class Products
    {
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategories ProductCategory { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
 