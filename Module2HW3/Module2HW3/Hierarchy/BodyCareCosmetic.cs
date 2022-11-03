using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class BodyCareCosmetic : CareCosmetic
    {
        public BodyCareCosmetic(int capacity, string name, float price, string purpose)
            : base(capacity, name, price, purpose)
        {
        }

        public string Operation()
        {
            return ToString();
        }

        public override string ToString()
        {
            return Capacity.ToString() + "ml " + Name.ToString() + " price: " + Price.ToString()
                + " purpose: " + Purpose.ToString() + "\n";
        }
    }
}
