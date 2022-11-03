using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class DecorativeCosmetic : Cosmetic, IDraw
    {
        public DecorativeCosmetic(int capacity, string name, float price, string purpose, ColorEnum color)
            : base(capacity, name, price, purpose)
        {
            Color = color;
        }

        public ColorEnum Color { get; set; }

        public string Draw()
        {
            return "I`m drawing color " + Color.ToString();
        }

        public override string ToString()
        {
            return Capacity.ToString() + "ml " + Name.ToString() + " price: " + Price.ToString()
                + " purpose: " + Purpose.ToString() + " color: " + Color.ToString() + "\n";
        }
    }
}
