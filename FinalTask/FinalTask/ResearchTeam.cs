using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    enum TimeFrame { Year, TwoYears, Long }

    class ResearchTeam: Team, IComparer<ResearchTeam>
    {
        public string ThemeName { get; set; }
        public TimeFrame Duration { get; set; }
        
        public List<Paper> Papers { get; private set; }
        public List<Person> Members { get; private set; }

        public Team Team
        {
            get
            {
                return new Team(Name, RegistrationNumber);
            }
            set
            {
                Name = value.Name;
                RegistrationNumber = value.RegistrationNumber;
            }
        }


        public Paper LatestPaper
        {
            get
            {
                if (Papers.Count == 0) return null;
                else
                {
                    Paper latestPaper = Papers[0];
                    foreach (Paper paper in Papers)
                    {
                        if (paper.PublicationDate > latestPaper.PublicationDate)
                            latestPaper = paper;
                    }
                    return latestPaper;
                }
            }
        }

        public bool this[TimeFrame duration] { get { return Duration == duration; } }
        
        public ResearchTeam(string themeName, string organizationName, int registrationNumber, TimeFrame duration):base(organizationName, registrationNumber)
        {
            ThemeName = themeName;
            Duration = duration;
            Papers = new List<Paper>();
            Members = new List<Person>();
        }

        public ResearchTeam() : this(" ", " ", 1, 0) { }

        public void AddPapers(params Paper[] newPapers)
        {
            Papers.AddRange(newPapers);
        }

        public void AddMembers(params Person[] newMembers)
        {
            Members.AddRange(newMembers);
        }

        public override string ToString()
        {
            string result = String.Format("Theme Name: {0}, Organisation Name: {1}, Registration Number: {2}, Duration: {3}",
                ThemeName, Name, RegistrationNumber, Duration == TimeFrame.Year ? "Year" : Duration == TimeFrame.TwoYears ? "TwoYears" : "Long");

            foreach (Paper paper in Papers)
            {
                result += String.Format("\n{0}", paper.ToString());
            }

            foreach (Person member in Members)
            {
                result += String.Format("\n{0}", member.ToString());
            }

            return result;
        }

        public virtual string ToShortString()
        {
            return String.Format("Theme Name: {0}, Organisation Name: {1}, Registration Number: {2}, Duration: {3}",
                ThemeName, Name, RegistrationNumber, Duration == TimeFrame.Year ? "Year" : Duration == TimeFrame.TwoYears ? "TwoYears" : "Long");
        }

        public override object DeepCopy()
        {
            ResearchTeam other = (ResearchTeam)MemberwiseClone();
            other.ThemeName = String.Copy(ThemeName);
            other.Name = String.Copy(Name);
            other.RegistrationNumber = RegistrationNumber;
            other.Duration = Duration;
            other.Papers = Papers.Select(x =>(Paper) x.DeepCopy()).ToList();
            other.Members = Members.Select(x => (Person)x.DeepCopy()).ToList();
            return other;
        }

        public IEnumerable GetMembersWithoutPublications()
        {
            foreach (Person m in Members)
            {
                if (!Papers.Exists(x => (x.Author == m)))
                {
                    yield return m;
                }
            }
        }
        public IEnumerable GetRecentPapers(int n)
        {
            foreach (Paper p in Papers)
            {
                if (DateTime.Today.Year - p.PublicationDate.Year <= n)
                {
                    yield return p;
                }
            }
        }

        public int Compare(ResearchTeam x, ResearchTeam y)
        {
            return x.ThemeName.CompareTo(y.ThemeName);
        }
    }
}
