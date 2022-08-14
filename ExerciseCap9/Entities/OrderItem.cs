using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCap9.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(Product product, double price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
