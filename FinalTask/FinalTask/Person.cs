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
        public DateTime BirthDate { get; private set; }

        public int BirthYear
        {
            get { return BirthDate.Year; }
            set { BirthDate = new DateTime(value, BirthDate.Month, BirthDate.Day); }
        }
        
        public Person (string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public Person() : this(" ", " ", new DateTime()) { }

        public override string ToString()
        {
            return String.Format("Person's firstname: {0}, lastname: {1}, birthday: {2}", FirstName, LastName, BirthDate);
        }

        public virtual string ToShortString()
        {
            return String.Format("Person's firstname: {0}, lastname: {1}", FirstName, LastName);
        }
    }
}
