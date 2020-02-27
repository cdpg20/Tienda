using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    public class Inventory
    {

        // Esta clase es la que te va a controlar las cantidades existentes de productos
        // aqui debes tener el diccionario de productos con las cantidades existentes
        // Dictionary<Product, int> inventoryOfProducts = new Dictionary<Product, int>();
        // Aqui cuando yo vendo un producto, debo reducir de la cantidad de productos existentes
        // 

        private Dictionary<Product, int> inventoryOfProducts = new Dictionary<Product, int>();

        
        string product;
        int quantity;
        int price;

        /// <summary>
        /// Remove this method
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public Inventory(string product, int quantity, int price)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = price;
        }

        public Inventory()
        {
        }


        public Product GetProductByName(string name)
        {
            return inventoryOfProducts.Keys.First(p => p.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        }

        public int GetQuantity(Product product)
        {
            return inventoryOfProducts[product];
        }

        public int GetQuantity(string name)
        {
            Product product = GetProductByName(name);
            return GetQuantity(product);

        }

        public void AddProductToInventory(Product product, int quantity) 
        {
            inventoryOfProducts.Add(product, quantity);
        }

        public void RemoveProductFromInventory(Product product, int quantity) 
        {
            if (InventoryContainsProduct(product))
            {

                if (inventoryOfProducts[product] > quantity)
                {
                    inventoryOfProducts[product] = inventoryOfProducts[product] - quantity;

                }
                else
                {
                    Console.WriteLine($"Cannot decrease the quantity of product={product.Name}, the Current Quantity of product={product.Name} is={inventoryOfProducts[product]}");
                }
            }
        }

        private bool InventoryContainsProduct(Product product) 
        {
            var existsProduct = false;

            foreach (KeyValuePair <Product, int> productData in inventoryOfProducts)
            {
                if (productData.Key.Equals(product))
                {
                    existsProduct = true;
                }
            }

            return existsProduct;
        }

        public void AddItem(Product product, int Quantity)
        {
            inventoryOfProducts.Add(product, Quantity);
        }

        public void AddProduct(Product product, int Price)
        {
            inventoryOfProducts.Add(product, Price);
        }

        public void DeleteItem(string Product)
        {
            inventoryOfProducts.Remove(inventoryOfProducts.Keys.First(p => p.Name.Equals(product)));
        }

        public void PrintItem()
        {
            foreach (KeyValuePair<Product, int> pair in inventoryOfProducts)
                Console.WriteLine("The item is: " + pair.Key.Name + "Your quantity is: " + pair.Value);
        }

        

        public void DeleteAllProducts()
        {
            inventoryOfProducts.Clear();
        }
    }

}
