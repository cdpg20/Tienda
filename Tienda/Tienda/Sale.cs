using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Sale
    {
        Dictionary<string, int> ProductList;

        public void DeleteProduct(string Product)
        {
            ProductList.Remove(Product);
        }

        public void PrintItem()
        {
            foreach (KeyValuePair<string, int> pair in ProductList)
                Console.WriteLine("The product is: " + pair.Key + "Your price is: " + pair.Value);
        }
    }
}
