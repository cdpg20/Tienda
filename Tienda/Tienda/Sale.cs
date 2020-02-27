using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Sale
    {
        public Dictionary<string, int> ProductList;
        private Inventory inventory;
        private ClientManager clientManager;

        public Sale(Inventory inventory, ClientManager clientManager)
        {
            this.inventory = inventory;
            this.clientManager = clientManager;
        }

        public Factura SaleProducts(List<Tuple<string, int>> productsToSell, string name, int ciOrNit)
        {
            Factura factura = null;
            bool sellSuccess = true;
            foreach (var item in productsToSell)
            {
                if (!(inventory.GetQuantity(item.Item1) > item.Item2))
                {
                    Console.WriteLine($"Cannot sell the product={item.Item1} due a insuficient quantity");
                    sellSuccess = false;
                }
            }

            if (sellSuccess)
            {
                Dictionary<Product, int> sellProducts = new Dictionary<Product, int>();
                Client client = new Client(name, ciOrNit);
                
                foreach (var product in productsToSell)
                {


                    Product currentProduct = inventory.GetProductByName(product.Item1);
                    inventory.RemoveProductFromInventory(currentProduct, product.Item2);
                    sellProducts.Add(currentProduct, product.Item2);
                }
                factura = new Factura(sellProducts, client);

            }
            return factura;
        }
         

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
