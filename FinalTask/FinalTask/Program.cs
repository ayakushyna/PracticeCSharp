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
            try
            {
                Random random = new Random();
                int nRow = 0, nColumn = 0;
                Console.WriteLine("Input number of rows and columns using such separators as ;/,/: .");
                string inStr = Console.ReadLine();

                char separator = ' ';
                if (inStr.Contains(';') || inStr.Contains(',') || inStr.Contains(':'))
                    separator = inStr.Contains(';') ? ';' : inStr.Contains(',') ? ',' : ':';
                else throw new Exception();

                string[] str = inStr.Split(separator);
                if (str.Length != 2) throw new Exception();

                nRow = Convert.ToInt32(str[0]);
                nColumn = Convert.ToInt32(str[1]);

                //Часть для Person

                /*
            

                Person[] people1 = new Person[nRow * nColumn];
                for(int i = 0; i < people1.Length;i++)
                {
                    people1[i] = new Person(i.ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }

                Person[,] people2 = new Person[nRow, nColumn];
                for (int i = 0; i < nRow; i++)
                {
                    for (int j = 0; j < nColumn; j++)
                    {
                        people2[i,j] = new Person(i.ToString(), (i + j).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                    }
                }

                int commonSize = nRow * nColumn;
                int stepRow = CountStepRow(commonSize);

                Person[][] people3 = new Person[stepRow][];
                for (int i = 0; i < stepRow-1; i++)
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
                foreach(Person person in people1)
                {
                    person.BirthYear = 1998;
                }
                int end1 = Environment.TickCount; 
                Console.WriteLine("Time: {0}",end1-start1);

                Console.WriteLine("\nTwo-dimensional array with {0} rows and {1} columns.", nRow , nColumn);
                int start2 = Environment.TickCount;
                foreach (Person person in people2)
                {
                    person.BirthYear = 1998;
                }
                int end2 = Environment.TickCount; 
                Console.WriteLine("Time: {0}", end1 - start1);

                Console.WriteLine("\nStepped array with {0} elements and {1} rows.", nRow * nColumn, stepRow);
                int start3 = Environment.TickCount;
                foreach(Person[] people in people3)
                    foreach (Person person in people)
                    {
                        person.BirthYear = 1998;
                    }
                int end31 = Environment.TickCount;
                Console.WriteLine("Time: {0}", end1 - start1);
                */

                //Часть для Задачи1

                ResearchTeam researchTeam = new ResearchTeam("Nature", "LoveNature", 100, TimeFrame.Long);
                Console.WriteLine(researchTeam.ToShortString());

                Console.WriteLine("As for long: {0}", researchTeam[TimeFrame.Long]);

                researchTeam.ThemeName = "Penguins";
                researchTeam.OrganisationName = "LovePenguins";
                researchTeam.RegistrationNumber = 101;
                researchTeam.Duration = TimeFrame.Year;
                Console.WriteLine(researchTeam.ToString());

                Paper[] papers = new Paper[5];
                for (int i = 0; i < papers.Length; i++)
                {
                    papers[i] = new Paper(i.ToString(), new Person(i.ToString(), (i + i).ToString(), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29))), new DateTime(random.Next(1900, 2018), random.Next(1, 12), random.Next(1, 29)));
                }
                researchTeam.AddPapers(papers);
                Console.WriteLine(researchTeam.ToString());

                Console.WriteLine("Latest publication: {0}", researchTeam.LatestPaper.ToString());


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
            catch
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadKey();
        }
    }
}
