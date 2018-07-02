using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    class Shop
    {
        public int ProductCode { get; }
        public string ProductName { get; }
        public string Measurement { get; }
        public double ProductPrice { get; }
        public DateTime CurrentDate { get; }
        public int BalanceOfGoodsAtBegin { get; }
        public int ReceivedGoods { get; }
        public int SoldGoods { get; }

        public Shop(int productCode, string productName, string measurement, double productPrice, 
            DateTime currentDate, int balanceOfGoodsAtBegin, int receivedGoods, int soldGoods)
        {
            ProductCode = productCode;
            ProductName = productName;
            Measurement = measurement;
            ProductPrice = productPrice;
            CurrentDate = currentDate;
            BalanceOfGoodsAtBegin = balanceOfGoodsAtBegin;
            ReceivedGoods = receivedGoods;
            SoldGoods = soldGoods;
        }
    }
}
