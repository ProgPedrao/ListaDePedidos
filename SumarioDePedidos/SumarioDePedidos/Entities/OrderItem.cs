using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumarioDePedidos.Entities
{
    class OrderItem
    {
        public int Quantidade { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantidade, double price, Product product)
        {
            Quantidade = quantidade;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantidade * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", R$" + Price + ", Quantidade: " + Quantidade + ", SubTotal: R$" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
