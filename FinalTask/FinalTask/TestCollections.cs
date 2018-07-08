using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class TestCollections
    {
        public List<Team> Teams { get; private set; }
        public List<string> Info { get; private set; }
        public Dictionary<Team, ResearchTeam> RTeams { get; private set; }
        public Dictionary<string, ResearchTeam> RInfo { get; private set; }

        public TestCollections()
        {
            Teams = new List<Team>();
            Info = new List<string>();
            RTeams = new Dictionary<Team, ResearchTeam>();
            RInfo = new Dictionary<string, ResearchTeam>();
        }
        
        public TestCollections (int number) : this()
        {
            for(int i = 0; i < number; i++)
            {
                AutoGeneration(i);
            }
        }

        public string Time(ResearchTeam researchTeam)
        {
            string info = "\n";
            Stopwatch time = new Stopwatch();
            
            time.Start();
            Team team = Teams.Find(x => x == researchTeam.Team);
            time.Stop();
            info += String.Format("Find in List<Team> - {0}\n", time.Elapsed);

            time.Reset();
            time.Start();
            string infoTeam = Info.Find(x => x == team.ToString());
            time.Stop();
            info += String.Format("Find in List<string> - {0}\n", time.Elapsed);

            time.Reset();
            time.Start();
            bool t1 = RTeams.ContainsKey(team);
            time.Stop();
            info += String.Format("Find by key in Dictionary<Team,ResearchTeam> - {0}\n", time.Elapsed);

            time.Reset();
            time.Start();
            bool t2 = RTeams.ContainsValue(researchTeam);
            time.Stop();
            info += String.Format("Find by value in  Dictionary<Team,ResearchTeam> - {0}\n", time.Elapsed);

            time.Reset();
            time.Start();
            bool t3 = RInfo.ContainsKey(researchTeam.ToString());
            time.Stop();
            info += String.Format("Find by key in  Dictionary<string,ResearchTeam> - {0}\n", time.Elapsed);

            time.Reset();
            time.Start();
            bool t4 = RInfo.ContainsValue(researchTeam);
            time.Stop();
            info += String.Format("Find by value in  Dictionary<string,ResearchTeam> - {0}\n", time.Elapsed);

            return info;
        }

        public ResearchTeam AutoGeneration(int index)
        {
            ResearchTeam researchTeam;
            if (index >= Teams.Count)
            {
                researchTeam = new ResearchTeam(index.ToString(), index.ToString(), index+1, TimeFrame.Year);
                Teams.Add(researchTeam as Team);
                Info.Add(researchTeam.ToString());
                RTeams.Add(researchTeam as Team, researchTeam);
                RInfo.Add(researchTeam.ToString(), researchTeam);
            }
            else
            {
                Team team = Teams[index];
                RTeams.TryGetValue(team,out researchTeam);
            }
            return researchTeam;
        }
    }
}
