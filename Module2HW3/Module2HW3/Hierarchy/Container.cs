using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public abstract class Container
    {
        public Container()
        {
            MaxCapacity = 0;
            Capacity = 0;
        }

        public Container(int capacity)
        {
            Capacity = capacity;
            MaxCapacity = Capacity;
        }

        public Container(int maxCapacity, int capacity)
        {
            MaxCapacity = maxCapacity;
            Capacity = capacity;
        }

        public int MaxCapacity { get; }
        public int Capacity { get; set; }
    }
}
