using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Program
    {
        static private int CountStepRow(int commonSize)
        {
            int min = 1, row = 1;
            while (commonSize > 0)
            {
                commonSize -= min;
                row++;
                min += row;
            }
            return --row;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            //int nRow = 0, nColumn = 0;
            /*
            try
            {
                /*
                Console.WriteLine("Input number of rows and columns using such separators as ;/,/: .");
                string inStr = Console.ReadLine();

                char separator = ' ';
                if (inStr.Contains(';') || inStr.Contains(',') || inStr.Contains(':'))
                    separator = inStr.Contains(';') ? ';' : inStr.Contains(',') ? ',' : ':';
                else throw new Exception("Wrong separator");

                string[] str = inStr.Split(separator);
                if (str.Length != 2) throw new Exception("Wrong amount of numbers");

                nRow = Convert.ToInt32(str[0]);
                nColumn = Convert.ToInt32(str[1]);
                */

            //Часть для Person

            /*
            Person[] people1 = new Person[nRow * nColumn];
            for (int i = 0; i < people1.Length; i++)
            {
                people1[i] = new Person(i.ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
            }

            Person[,] people2 = new Person[nRow, nColumn];
            for (int i = 0; i < nRow; i++)
            {
                for (int j = 0; j < nColumn; j++)
                {
                    people2[i, j] = new Person(i.ToString(), (i + j).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }
            }

            int commonSize = nRow * nColumn;
            int stepRow = CountStepRow(commonSize);

            Person[][] people3 = new Person[stepRow][];
            for (int i = 0; i < stepRow - 1; i++)
            {
                people3[i] = new Person[i];
                for (int j = 0; j < i; j++)
                {
                    people3[i][j] = new Person(i.ToString(), (i + j).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                    --commonSize;
                }
            }

            people3[stepRow - 1] = new Person[commonSize];
            for (int j = 0; j < commonSize; j++)
            {
                people3[stepRow - 1][j] = new Person((stepRow - 1).ToString(), (stepRow - 1 + j).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
            }

            Console.WriteLine("\nCommon array with {0} elements.", nRow * nColumn);
            int start1 = Environment.TickCount;
            foreach (Person person in people1)
            {
                person.BirthYear = 1998;
            }
            int end1 = Environment.TickCount;
            Console.WriteLine("Time: {0}", end1 - start1);

            Console.WriteLine("\nTwo-dimensional array with {0} rows and {1} columns.", nRow, nColumn);
            int start2 = Environment.TickCount;
            foreach (Person person in people2)
            {
                person.BirthYear = 1998;
            }
            int end2 = Environment.TickCount;
            Console.WriteLine("Time: {0}", end1 - start1);

            Console.WriteLine("\nStepped array with {0} elements and {1} rows.", nRow * nColumn, stepRow);
            int start3 = Environment.TickCount;
            foreach (Person[] people in people3)
                foreach (Person person in people)
                {
                    person.BirthYear = 1998;
                }
            int end31 = Environment.TickCount;
            Console.WriteLine("Time: {0}", end1 - start1);
        }
        */

            //Часть для Задачи1
            /*
                ResearchTeam researchTeam = new ResearchTeam("Nature", "LoveNature", 100, TimeFrame.Long);
                Console.WriteLine(researchTeam.ToShortString());

                Console.WriteLine("\nAs for long: {0}", researchTeam[TimeFrame.Long]);

                researchTeam.ThemeName = "Penguins";
                researchTeam.OrganisationName = "LovePenguins";
                researchTeam.RegistrationNumber = 101;
                researchTeam.Duration = TimeFrame.Year;
                Console.WriteLine("\nBefore adding papers: " + researchTeam.ToString());

                Paper[] papers = new Paper[5];
                for (int i = 0; i < papers.Length; i++)
                {
                    papers[i] = new Paper(i.ToString(), new Person(i.ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }
                researchTeam.AddPapers(papers);
                Console.WriteLine("\nAfter adding papers: "+ researchTeam.ToString());

                Console.WriteLine("\nLatest publication: {0}", researchTeam.LatestPaper.ToString());


                Paper[] papers1 = new Paper[nRow * nColumn];
                for (int i = 0; i < papers1.Length; i++)
                {
                    papers1[i] = new Paper(i.ToString(), new Person(i.ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }

                Paper[,] papers2 = new Paper[nRow, nColumn];
                for (int i = 0; i < nRow; i++)
                {
                    for (int j = 0; j < nColumn; j++)
                    {
                        papers2[i, j] = new Paper(i.ToString(), new Person(i.ToString(), (i + j).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                    }
                }

                int commonSize = nRow * nColumn;
                int stepRow = CountStepRow(commonSize);

                Paper[][] papers3 = new Paper[stepRow][];
                for (int i = 0; i < stepRow - 1; i++)
                {
                    papers3[i] = new Paper[i];
                    for (int j = 0; j < i; j++)
                    {
                        papers3[i][j] = new Paper(i.ToString(), new Person(i.ToString(), (i + j).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                        --commonSize;
                    }
                }
                papers3[stepRow - 1] = new Paper[commonSize];
                for (int j = 0; j < commonSize; j++)
                {
                    papers3[stepRow - 1][j] = new Paper(j.ToString(), new Person(j.ToString(), (j + j).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }


                Console.WriteLine("\nCommon array with {0} elements.", nRow * nColumn);
                int start1 = Environment.TickCount;
                foreach (Paper paper in papers1)
                {
                    paper.Name = "Papyrus";
                }
                int end1 = Environment.TickCount;
                Console.WriteLine("Time: {0}", end1 - start1);

                Console.WriteLine("\nTwo-dimensional array with {0} rows and {1} columns.", nRow, nColumn);
                int start2 = Environment.TickCount;
                foreach (Paper paper in papers2)
                {
                    paper.Name = "Papyrus";
                }
                int end2 = Environment.TickCount;
                Console.WriteLine("Time: {0}", end1 - start1);

                Console.WriteLine("\nStepped array with {0} elements and {1} rows.", nRow * nColumn, stepRow);
                int start3 = Environment.TickCount;
                foreach (Paper[] papers0 in papers3)
                    foreach (Paper paper in papers0)
                    {
                        paper.Name = "Papyrus";
                    }
                int end31 = Environment.TickCount;
                Console.WriteLine("Time: {0}", end1 - start1);
            }
            */
            //Часть для Задачи2
            /*
            Team team1 = new Team("LovePenguins", 101);
            Team team2 = new Team("LovePenguins", 101);

            Console.WriteLine("Hash Code of 1 Team: {0}", team1.GetHashCode());
            Console.WriteLine("Hash Code of 2 Team: {0}", team2.GetHashCode());
            Console.WriteLine("Reference equality: {0}", ReferenceEquals(team1,team2));

            Console.WriteLine("\nTry to make registration number -101: ");
            team1.RegistrationNumber = -100;
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        ResearchTeam researchTeam = new ResearchTeam("Pandas", "LovePandas", 102, TimeFrame.TwoYears);

        Paper[] papers = new Paper[2];
        for (int i = 0; i < papers.Length; i++)
        {
            papers[i] = new Paper(i.ToString(), new Person(i.ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))), new DateTime(random.Next(2016, 2018), random.Next(1, 12), random.Next(1, 29)));
        }
        researchTeam.AddPapers(papers);

        Person[] members = new Person[3];
        for (int i = 0; i < members.Length; i++)
        {
            members[i] = new Person(i.ToString(),  (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
        }
        researchTeam.AddMembers(members);

        Console.WriteLine("\nFull info of the research team: " + researchTeam.ToString());
        Console.WriteLine("\nTeam info of the research team: " + researchTeam.Team.ToString());

        ResearchTeam researchTeamCopy = (ResearchTeam)researchTeam.DeepCopy();
        researchTeam.RegistrationNumber = 103;
        researchTeam.AddMembers(new Person("4", "8", new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))));
        Console.WriteLine("\nFull info of the original research team: " + researchTeam.ToString());
        Console.WriteLine("\nFull info of copy of the research team: " + researchTeamCopy.ToString());

        Console.WriteLine("\nMembers with no publications: ");
        foreach (Person p in researchTeam.GetMembersWithoutPublications())
        {
            Console.WriteLine(p.ToString());
        }

        Console.WriteLine("\nTwo-year-old publications: ");
        foreach (Paper p in researchTeam.GetRecentPapers(2))
        {
            Console.WriteLine(p.ToString());
        }
        */
            /*
                ResearchTeam researchTeam1 = new ResearchTeam("Dolphins", "LoveDolphins", 102, TimeFrame.TwoYears);

                Person[] members1 = new Person[2];
                for (int i = 0; i < members1.Length; i++)
                {
                    members1[i] = new Person(i.ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }
                researchTeam1.AddMembers(members1);

                Paper[] papers1 = new Paper[2];
                for (int i = 0; i < papers1.Length; i++)
                {
                    papers1[i] = new Paper(i.ToString(), researchTeam1.Members[i], new DateTime(random.Next(2016, 2018), random.Next(1, 12), random.Next(1, 29)));
                }
                researchTeam1.AddPapers(papers1);

                ResearchTeam researchTeam2 = new ResearchTeam("Pandas", "LovePandas", 101, TimeFrame.Year);

                Person[] members2 = new Person[2];
                for (int i = 0; i < members2.Length; i++)
                {
                    members2[i] = new Person((i * i+i).ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }
                researchTeam2.AddMembers(members2);

                Paper[] papers2 = new Paper[1];
                for (int i = 0; i < papers2.Length; i++)
                {
                    papers2[i] = new Paper((i * i + i).ToString(), researchTeam2.Members[i], new DateTime(random.Next(2016, 2018), random.Next(1, 12), random.Next(1, 29)));
                }
                researchTeam2.AddPapers(papers2);

                ResearchTeamCollection researchTeamCollection = new ResearchTeamCollection();
                researchTeamCollection.AddResearchTeams(researchTeam1, researchTeam2);
                Console.WriteLine("\nFull info of research teams:" + researchTeamCollection.ToString());

                researchTeamCollection.SortByRegistratioNumber();
                Console.WriteLine("\nFull info of research teams after sorting by reg number:" + researchTeamCollection.ToString());

                researchTeamCollection.SortByThemeName();
                Console.WriteLine("\nFull info of research teams after sorting by theme:" + researchTeamCollection.ToString());

                researchTeamCollection.SortByNumberOfPapers();
                Console.WriteLine("\nFull info of research teams after sorting by number of publications:" + researchTeamCollection.ToString());

                Console.WriteLine("\nMinimal registration number: " + researchTeamCollection.MinRegistrationNumber.ToString());

                List<ResearchTeam> researchTeamsTwoYears = researchTeamCollection.TwoYearsResearchTeam.ToList();
                Console.WriteLine("\nTwo-year-old teams: ");
                foreach(ResearchTeam r in researchTeamsTwoYears)
                {
                    Console.WriteLine(r.ToString());
                }

                Console.WriteLine("\nTeams with 2 members: ");
                List<ResearchTeam> twoMemberTeams =  researchTeamCollection.NGroup(2);
                var groups = twoMemberTeams.GroupBy(x => x.Papers.Count);
                IEnumerable<ResearchTeam> researchTeams = groups.SelectMany(g => g);
                foreach (var teams in researchTeams)
                {
                    Console.WriteLine(teams.ToString());
                }
                */


            TestCollections test = new TestCollections(1000);
            Console.WriteLine("First element search: "+ test.Time(test.AutoGeneration(0)));
            Console.WriteLine("Middle element search: " + test.Time(test.AutoGeneration(499)));
            Console.WriteLine("Last element search: " + test.Time(test.AutoGeneration(999)));
            Console.WriteLine("Not existed element search: " + test.Time(test.AutoGeneration(1000)));

            Console.ReadKey();
        }
    }
}
