using System;

namespace Tienda
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }

        // El producto tiene, nombre, precio, marca
        public Product(string name, int price, string brand) 
        {
            Name = name;
            Price = price;
            Brand = brand;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Product product = (Product)obj;
                return (product.Name == this.Name) && (product.Price == this.Price) && (product.Brand == this.Brand);
            }
        }

    }
}