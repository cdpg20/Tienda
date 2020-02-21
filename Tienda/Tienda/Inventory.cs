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

        Dictionary<string, int> ItemsList = new Dictionary<string, int>();
        Dictionary<string, int> ProductList = new Dictionary<string, int>();
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

        public void AddProductToInventory(Product product, int quantity) 
        {
            inventoryOfProducts.Add(product, quantity);
        }

        public void RemoveProductFromInventory(Product product, int quantity) 
        {
            int currentNumberOfProducts;

            var dictionaryContains = InventoryContainsProduct(product);

            if (InventoryContainsProduct(product))
            {

                foreach (KeyValuePair<Product, int> productData in inventoryOfProducts)
                {
                    if (productData.Key.Equals(product))
                    {
                        productData.Value
                    }
                }

                currentNumberOfProducts = inventoryOfProducts[product];

                 // 20 > 5
                if (currentNumberOfProducts > quantity)
                {
                    currentNumberOfProducts = currentNumberOfProducts - quantity;
                    // voy a registrar los cambios en el diccionario
                    // esto es el Valor 
                    inventoryOfProducts[product] = currentNumberOfProducts;
                }
                else 
                {
                    currentNumberOfProducts = currentNumberOfProducts - currentNumberOfProducts;
                    inventoryOfProducts[product] = currentNumberOfProducts;
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

        public void AddItem(string Product, int Quantity)
        {
            ItemsList.Add(Product, Quantity);
        }

        public void AddProduct(string Product, int Price)
        {
            ProductList.Add(Product, Price);
        }

        public void DeleteItem(string Product)
        {
            ItemsList.Remove(Product);
        }

        public void PrintItem()
        {
            foreach (KeyValuePair<string, int> pair in ItemsList)
                Console.WriteLine("The item is: " + pair.Key + "Your quantity is: " + pair.Value);
        }

        public void DeleteAllItems()
        {
            ItemsList.Clear();
        }

        public void DeleteAllProducts()
        {
            ProductList.Clear();
        }
    }

}
