using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birthday { get; private set; }
        public int BirthYear
        {
            get { return Birthday.Year; }
            set { Birthday = new DateTime(value, Birthday.Month, Birthday.Day); }
        }
        public Person()
        {
            FirstName = " ";
            LastName = " ";
            Birthday = new DateTime();
        }

        public Person (string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return String.Format("Person's firstname: {0}, lastname: {1}, birthday: {2}", FirstName, LastName, Birthday);
        }

    }
}
