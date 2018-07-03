using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    interface ICarriage
    {
        double Price { get; set; }
        int Places { get; set; }
        double TotalIncome { get; set; }

        void Cost();
        string Info();
    }
}
