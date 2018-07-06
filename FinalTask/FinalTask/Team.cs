using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Team
    {
        public string Name {get; private set;}
        public int RegistrationNumber
        {
            get; 
            private set
            {
                if( value <= 0 ) throw new Exception("Постарайтесь побольше");
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
            Team teamObj = obj as Team;
            if (teamObj == null)
                return false;
            else
                return Name.Equals(teamObj.Name) &&
                    RegistrationNumber.Equals(teamObj.RegistrationNumber);

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

        public override object DeepCopy()
        {
            Team other = (Team)this.MemberwiseClone();
            other.Name = String.Copy(Name);
            other.RegistrationNumber = RegistrationNumber;
            return other;
        }
    }
}
