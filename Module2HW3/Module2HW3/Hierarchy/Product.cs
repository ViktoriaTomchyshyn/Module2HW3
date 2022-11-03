using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Product : Container, IComparable<Product>
    {
        public Product()
            : base()
        {
            Name = string.Empty;
            Price = 0;
        }

        public Product(int capacity, string name, float price)
            : base(capacity)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public float Price { get; set; }

        public int CompareTo(Product other)
        {
            if (other == null)
            {
                return 1;
            }

            return Price.CompareTo(other.Price);
        }
    }
}
