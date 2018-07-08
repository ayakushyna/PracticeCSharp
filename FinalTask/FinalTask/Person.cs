using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Person: INameAndCopy
    {
        public string Name { get; set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }

        public int BirthYear
        {
            get { return BirthDate.Year; }
            set { BirthDate = new DateTime(value, BirthDate.Month, BirthDate.Day); }
        }
        
        public Person (string firstName, string lastName, DateTime birthDate)
        {
            Name = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public Person() : this(" ", " ", new DateTime()) { }

        public override string ToString()
        {
            return String.Format("Person's firstname: {0}, lastname: {1}, birthday: {2}", Name, LastName, BirthDate.ToShortDateString());
        }

        public virtual string ToShortString()
        {
            return String.Format("Person's firstname: {0}, lastname: {1}", Name, LastName);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                Person personObj = obj as Person;
                return Name.Equals(personObj.Name) &&
                    LastName.Equals(personObj.LastName) &&
                    BirthDate.Equals(personObj.BirthDate);
            }

        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^
            LastName.GetHashCode() ^
            BirthDate.GetHashCode();
        }

        public object DeepCopy()
        {
            Person other = (Person)MemberwiseClone();
            other.Name = String.Copy(Name);
            other.LastName = String.Copy(LastName);
            other.BirthDate = new DateTime(BirthDate.Year, BirthDate.Month, BirthDate.Day);
            return other;
        }
    }
}
