using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Student: Man
    {
        public string Faculty { get; }
        public int Year { get; }
        public int AverageScore { get; }
        public bool Scholarship { get; private set; }

        public Student(string name, int bYear, string faculty, int year, int averageScore) : base(name, year)
        {
            Faculty = faculty;
            Year = year;
            AverageScore = averageScore;
        }

        public void Grant(int minScore)
        {
            Scholarship = (AverageScore >= minScore);
        }

        public void PrintS()
        {
            Console.WriteLine("Faculty: {0}, year: {1}, average score: {2}, scholarship: {3}", Faculty, Year, AverageScore, Scholarship);
        }
    }
}
