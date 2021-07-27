using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumarioDePedidos.Entities;
using SumarioDePedidos.Entities.Enums;

namespace SumarioDePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, productName, status;
            DateTime birthDate;
            int qtdProduto, qtdItemsInOrder;
            double productPrice;
            Client client;
            Order order;

            Console.Write("Dados do cliente: \n");

            Console.Write("Insira o nome do cliente: ");
            name = Console.ReadLine();

            Console.Write("Insira o email do cliente: ");
            email = Console.ReadLine();

            Console.Write("Insira a data de nascimento do cliente: (dd/MM/yyyy HH/mm/ss)");
            birthDate = DateTime.Parse(Console.ReadLine());

            client = new Client(name, email, birthDate);

            Console.Write("Dados do produto - \n");

            Console.Write("Status do produto: ");
            status = Console.ReadLine();


            order = new Order(DateTime.Now, (OrderStatus) Enum.Parse(typeof(OrderStatus), status), client);

            Console.Write("Quantos produtos terão nessa ordem? ");
            qtdItemsInOrder = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= qtdItemsInOrder; i++)
            {
                Console.Write($"Insira os dados do #{i} produto: \n");

                Console.Write("Nome do Produto: ");
                productName = Console.ReadLine();

                Console.Write("Preco do Produto: ");
                productPrice = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade do Produto: ");
                qtdProduto = Convert.ToInt32(Console.ReadLine());

                Product produto = new Product(productName, productPrice);
                OrderItem item = new OrderItem(qtdProduto, productPrice, produto);

                order.AddItem(item);
            }

            Console.WriteLine(order.ToString());
        }
    }
}
