using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class CareCosmetic : Cosmetic, ICare
    {
        public CareCosmetic(int capacity, string name, float price, string purpose)
            : base(capacity, name, price, purpose)
        {
        }

        public string Care()
        {
            return "I`m caring about your body";
        }
    }
}
