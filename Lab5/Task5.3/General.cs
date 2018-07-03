using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class General: ICarriage, ICloneable, IComparable<General>
    {
        public double Price { get; set; }
        public int Places { get; set; }
        public double TotalIncome { get; set; }

        public General(double price, int places)
        {
            Price = price;
            Places = places;
        }

        public virtual void Cost()
        {
            TotalIncome = Price * Places;
        }

        public virtual string Info()
        {
            return String.Format("General - Price: {0:F2}, Places: {1}, Income: {2:F2}", Price, Places, TotalIncome);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(General general)
        {
            return TotalIncome.CompareTo(general.TotalIncome);
        }
    }
}
