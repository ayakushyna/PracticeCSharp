using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Team: INameAndCopy, IComparable<Team>
    {
        public string Name {get; set;}

        protected int registrationNumber;
        public int RegistrationNumber {
            get { return registrationNumber; }
            set
            {
                if( value <= 0 ) throw new Exception("Wrong number");
                else registrationNumber = value;
            } 
        }

        public Team(string name, int registrationNumber)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
        }

        public Team() : this(" ", 1) { }

        public override string ToString()
        {
            return String.Format("Team's Name: {0}, Registration Number: {1}", Name, RegistrationNumber);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                Team teamObj = obj as Team; 
                return Name.Equals(teamObj.Name) &&
                    RegistrationNumber.Equals(teamObj.RegistrationNumber);
            }

        }

        public static bool operator ==(Team t1, Team t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Team t1, Team t2)
        {
            return !t1.Equals(t2);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^
            RegistrationNumber.GetHashCode();
        }

        public virtual object DeepCopy()
        {
            Team other = (Team)MemberwiseClone();
            other.Name = String.Copy(Name);
            other.RegistrationNumber = RegistrationNumber;
            return other;
        }

        public int CompareTo(Team teamObj)
        {
            return RegistrationNumber.CompareTo(teamObj.RegistrationNumber);
        }
    }
}
