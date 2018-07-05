using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    enum TimeFrame { Year, TwoYears, Long }

    class ResearchTeam
    {
        public string ThemeName { get; set; }
        public string OrganisationName { get; set; }
        public int RegistrationNumber { get; set; }
        public TimeFrame Duration { get; set; }
        
        public Paper[] Papers { get; private set; }

        public Paper LatestPaper
        {
            get
            {
                if (Papers.Length == 0) return null;
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
        
        public ResearchTeam(string themeName, string organizationName, int registrationNumber, TimeFrame duration)
        {
            ThemeName = themeName;
            OrganisationName = organizationName;
            RegistrationNumber = registrationNumber;
            Duration = duration;
            Papers = new Paper[0];
        }

        public ResearchTeam() : this(" ", " ", 0, 0) { Papers = new Paper[0]; }

        public void AddPapers(params Paper[] newPapers)
        {
            Paper[] NewPapers = new Paper[Papers.Length + newPapers.Length];
            Papers.CopyTo(NewPapers, 0);
            newPapers.CopyTo(NewPapers, Papers.Length);
            Papers = NewPapers;
        }

        public override string ToString()
        {
            string result = String.Format("Theme Name: {0}, Organisation Name: {1}, Registration Number: {2}, Duration: {3}",
                ThemeName, OrganisationName, RegistrationNumber, Duration == TimeFrame.Year ? "Year" : Duration == TimeFrame.TwoYears ? "TwoYears" : "Long");

            foreach (Paper paper in Papers)
            {
                result += String.Format("\n{0}", paper.ToString());
            }

            return result;
        }

        public virtual string ToShortString()
        {
            return String.Format("Theme Name: {0}, Organisation Name: {1}, Registration Number: {2}, Duration: {3}",
                ThemeName, OrganisationName, RegistrationNumber, Duration == TimeFrame.Year ? "Year" : Duration == TimeFrame.TwoYears ? "TwoYears" : "Long");
        }
    }
}
