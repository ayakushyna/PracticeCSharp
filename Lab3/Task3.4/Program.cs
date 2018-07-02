using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shop> shops = new List<Shop>
            {
                new Shop(111, "Computer", "kg", 500, new DateTime(2015, 7, 20), 20, 15, 30),
                new Shop(112, "Ball", "kg", 4.8, new DateTime(2015, 7, 20), 30, 10, 40),
                new Shop(211, "Glasses", "kg", 20, new DateTime(2015, 7, 20), 40, 18, 50),
                new Shop(121, "Phone", "kg", 125.5, new DateTime(2015, 7, 21), 50, 12, 60),
                new Shop(311, "Pen", "kg", 3.7, new DateTime(2015, 7, 20), 60, 19, 70)
            };

            DateTime date = new DateTime(2015, 7, 20);
            var specShops = shops.Where(x => (x.CurrentDate == date));

            foreach(var shop in specShops)
            {
                Console.WriteLine("Product Name: {0},Balance Of Goods At Begin: {1},Received Goods: {2}, Sold Goods {3}",
                    shop.ProductName, shop.BalanceOfGoodsAtBegin, shop.ReceivedGoods, shop.SoldGoods);
            }

            Console.ReadKey();
        }
    }
}
