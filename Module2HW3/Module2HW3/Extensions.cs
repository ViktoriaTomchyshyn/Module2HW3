using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public static class Extensions
    {
        public static Cosmetic[] FindCosmeticsWithLowerPrice(this Store store)
        {
            int quantity = 0;
            foreach (var item in store.Cosmetics)
            {
                if (item.Price < store.Cosmetics.GetAveragePrice())
                {
                    quantity++;
                }
            }

            Cosmetic[] result = new Cosmetic[quantity];

            int k = 0;

            foreach (var item in store.Cosmetics)
            {
                if (item.Price < store.Cosmetics.GetAveragePrice())
                {
                    result[k] = item;
                    k++;
                }
            }

            return result;
        }

        public static Cosmetic[] FindCosmeticsWithBiggestCapacity(this Store store)
        {
            int quantity = 0;
            foreach (var item in store.Cosmetics)
            {
                if (item.Capacity > store.Cosmetics.GetAverageCapacity())
                {
                    quantity++;
                }
            }

            Cosmetic[] result = new Cosmetic[quantity];

            int k = 0;

            foreach (var item in store.Cosmetics)
            {
                if (item.Capacity > store.Cosmetics.GetAverageCapacity())
                {
                    result[k] = item;
                    k++;
                }
            }

            return result;
        }

        public static Cosmetic[] GetByName(this Store store, string name)
        {
            int quantity = 0;
            foreach (var item in store.Cosmetics)
            {
                if (item.Name.CompareTo(name) == 0)
                {
                    quantity++;
                }
            }

            Cosmetic[] result = new Cosmetic[quantity];

            int k = 0;

            foreach (var item in store.Cosmetics)
            {
                if (item.Name.CompareTo(name) == 0)
                {
                    result[k] = item;
                    k++;
                }
            }

            return result;
        }

        public static string FormatCosmeticsArray(this Cosmetic[] cosmetics)
        {
            string result = string.Empty;
            foreach (var item in cosmetics)
            {
                result += item.ToString();
            }

            return result;
        }

        public static double GetAveragePrice(this Cosmetic[] cosmetics)
        {
            float sum = 0;
            foreach (var cosmet in cosmetics)
            {
                sum += cosmet.Price;
            }

            return Math.Round(sum / cosmetics.Length, 2);
        }

        public static double GetAverageCapacity(this Cosmetic[] cosmetics)
        {
            float sum = 0;
            foreach (var cosmet in cosmetics)
            {
                sum += cosmet.Capacity;
            }

            return Math.Round(sum / cosmetics.Length, 2);
        }
    }
}
