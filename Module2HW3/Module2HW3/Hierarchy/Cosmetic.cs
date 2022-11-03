using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Cosmetic : Product
    {
        public Cosmetic(int capacity, string name, float price, string purpose)
            : base(capacity, name, price)
        {
            Purpose = purpose;
        }

        public string Purpose { get; set; }
    }
}
