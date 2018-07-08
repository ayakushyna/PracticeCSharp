using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Paper: INameAndCopy
    {
        public string Name { get; set; }
        public Person Author { get; set; }
        public DateTime PublicationDate { get; set; }
        
        public Paper(string name, Person author, DateTime publicationDate)
        {
            Name = name;
            Author = author;
            PublicationDate = publicationDate;
        }

        public Paper() : this(" ", new Person(), new DateTime()) { }

        public override string ToString()
        {
            return String.Format("Paper's name: {0}, Author - {1}, Publication date: {2}", Name, Author.ToString(), PublicationDate.ToShortDateString());
        }

        public virtual object DeepCopy()
        {
            Paper other = (Paper)MemberwiseClone();
            other.Name = String.Copy(Name);
            other.Author = (Person)Author.DeepCopy();
            other.PublicationDate = new DateTime(PublicationDate.Year, PublicationDate.Month, PublicationDate.Day);
            return other;
        }
    }
}
