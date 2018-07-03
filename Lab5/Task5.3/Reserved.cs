using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Reserved: General
    {
        public double ExtraService { get; set; }

        public Reserved(double price, int places, double extraService) : base(price,places)
        {
            ExtraService = extraService;
        }

        public override void Cost()
        {
            TotalIncome = Price * Places + ExtraService * Places * 0.5;
        }

        public override string Info()
        {
            return String.Format("Reserved - Price: {0:F2}, Places: {1}, Extra Service: {2:F2}, Income: {3:F2}", Price, Places, ExtraService, TotalIncome);
        }
    }
}
