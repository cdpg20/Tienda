using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {

            Product mabelCookies = new Product("Galletas Mabel", 5, "Mabel");
            Product sardinas = new Product("Lata de Sardina", 15, "Lombarda");
            Product cocacolas = new Product("Botella de Coca Cola", 12, "Coca Cola");

            Inventory inventory = new Inventory();
            inventory.AddProductToInventory(mabelCookies, 4);
            inventory.AddProductToInventory(sardinas, 10);
            inventory.AddProductToInventory(cocacolas, 20);

            var cokeThatISell = new Product("Botella de Coca Cola", 12, "Coca Cola");

            var isSameProduct = cocacolas.Equals(cokeThatISell);

            inventory.RemoveProductFromInventory(cokeThatISell, 5);

            Console.WriteLine("Holas");


        }
    }
}
