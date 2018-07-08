using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class ResearchTeamCollection
    {
        public List<ResearchTeam> ResearchTeams { get; private set; }

        public int MinRegistrationNumber
        {
            get
            {
                if (ResearchTeams.Count == 0) return 1;
                int min = ResearchTeams[0].RegistrationNumber;
                foreach (ResearchTeam researchTeam in ResearchTeams)
                {
                    if (researchTeam.RegistrationNumber < min)
                        min = researchTeam.RegistrationNumber;
                }
                return min;
            }
        }

        public IEnumerable<ResearchTeam> TwoYearsResearchTeam
        {
            get
            {
                return ResearchTeams.Where(x => x.Duration == TimeFrame.TwoYears); 
            }
        }

        public ResearchTeamCollection()
        {
            ResearchTeams = new List<ResearchTeam>();
        }

        public List<ResearchTeam> NGroup(int value)
        {
            var group = ResearchTeams.GroupBy(x => x.Members.Count).Where(x => x.Key == value);
            IEnumerable<ResearchTeam> researchTeams = group.SelectMany(g => g);
            return researchTeams.ToList();
        }

        public void AddDefaults()
        {
            ResearchTeams.Add(new ResearchTeam());
        }

        public void AddResearchTeams(params ResearchTeam[] newResearchTeams)
        {
            ResearchTeams.AddRange(newResearchTeams);
        }

        public override string ToString()
        {
            string result = "";
            foreach (ResearchTeam researchTeam in ResearchTeams)
            {
                result += String.Format("\n{0}", researchTeam.ToString());
            }
            return result;
        }

        public virtual string ToShortString()
        {
            string result = "";
            foreach (ResearchTeam researchTeam in ResearchTeams)
            {
                result += String.Format("\n{0}", researchTeam.ToShortString());
            }
            return result;
        }

        public void SortByRegistratioNumber()
        {
            ResearchTeams.Sort();
        }

        public void SortByThemeName()
        {
            ResearchTeams.Sort(new ResearchTeam().Compare);
        }

        public void SortByNumberOfPapers()
        {
            ResearchTeams.Sort(new PublicationsNumberComparer().Compare);
        }

    }

}
