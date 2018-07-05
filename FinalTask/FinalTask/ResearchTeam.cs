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
        public string ThemeName { get; private set; }
        public string OrganisationName { get; private set; }
        public int RegistrationNumber { get; private set; }
        public TimeFrame Duration { get; private set; }
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
                        if (paper.PublicationDate < latestPaper.PublicationDate)
                            latestPaper = paper;
                    }
                    return latestPaper;
                }
            }
        }


        public ResearchTeam()
        {
            ThemeName = " ";
            OrganisationName = " ";
            RegistrationNumber = 0;
            Duration = 0;
        }

        public ResearchTeam(string themeName, string organizationName, int registrationNumber, TimeFrame duration)
        {
            ThemeName = themeName;
            OrganisationName = organizationName;
            RegistrationNumber = registrationNumber;
            Duration = duration;
        }


    }
}
