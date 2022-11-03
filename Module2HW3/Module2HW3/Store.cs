using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Module2HW3
{
    public class Store
    {
        private static Store _instance;
        private Cosmetic[] _cosmetics;

        public Store()
        {
            _cosmetics = null;
        }

        public Cosmetic[] Cosmetics
        {
            get { return _cosmetics; }
            set { _cosmetics = value; }
        }

        public static Store GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Store();
            }

            return _instance;
        }

        public Product[] GetProducts()
        {
            return _cosmetics;
        }

        public Product GetProduct(int id)
        {
            return _cosmetics[id - 1];
        }

        public Cosmetic[] SortByPrice()
        {
            Cosmetic temp;
            for (int j = 0; j <= _cosmetics.Length - 2; j++)
            {
                for (int i = 0; i <= _cosmetics.Length - 2; i++)
                {
                    if (_cosmetics[i].CompareTo(_cosmetics[i + 1]) > 0)
                    {
                        temp = _cosmetics[i + 1];
                        _cosmetics[i + 1] = _cosmetics[i];
                        _cosmetics[i] = temp;
                    }
                }
            }

            return _cosmetics;
        }

        public override string ToString()
        {
            string result = "---Cosmetics available in the store---\n";
            foreach (var item in _cosmetics)
            {
                result += item.ToString();
            }

            return result;
        }
    }
}
