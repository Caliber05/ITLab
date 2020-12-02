using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	
namespace q2
{
    class Item
    {
        private int price;
        private string name;
        public delegate void PriceChangedHandler(int v);
        public event PriceChangedHandler PriceChanged;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(value);
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i = new Item();
            i.PriceChanged += ShowPriceChangedMessage;
            i.Price = 20;
            i.Price = 200;
            Console.Read();

        }

        private static void ShowPriceChangedMessage(int v)
        {
            Console.WriteLine("New Price : "+v);
        }
    }
}
