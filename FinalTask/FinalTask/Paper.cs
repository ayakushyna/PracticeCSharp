using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Paper
    {
        public string Name { get; set; }
        public Person Author { get; set; }
        public DateTime PublicationDate { get; set; }

        public Paper()
        {
            Name = " ";
            Author = new Person();
            PublicationDate = new DateTime();
        }

        public Paper(string name, Person author, DateTime publicationDate)
        {
            Name = name;
            Author = author;
            PublicationDate = publicationDate;
        }

        public override string ToString()
        {
            return String.Format("Paper's name: {0} \nAuthor - {1} \nPublication date: {2}", Name, Author.ToString(), PublicationDate.ToString());
        }
    }
}
