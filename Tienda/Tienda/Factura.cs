using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Factura
    {
        private Dictionary<Product, int> ProductList;
        private Client client;

        public Factura(Dictionary<Product, int> productList, Client client) 
        {
            ProductList = productList;
            this.client = client;
        }

    }
}
