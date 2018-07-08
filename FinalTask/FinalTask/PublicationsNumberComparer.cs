using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class PublicationsNumberComparer: IComparer<ResearchTeam>
    {

        public int Compare(ResearchTeam x, ResearchTeam y)
        {
            return x.Papers.Count.CompareTo(y.Papers.Count); ;
        }
    }
}
