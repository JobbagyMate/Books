using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Author
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName; 
            set
            {
                if (value.Length < 3 ||
                    value.Length > 32)
                    throw new Exception("Invalid first name!");
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName; 
            set
            {
                if (value.Length < 3 ||
                    value.Length > 32)
                    throw new Exception("Invalid last name!");
                lastName = value;
            }
        }
        public Guid GUID { get; set; }

        public Author(string fullName)
        {
            GUID = Guid.NewGuid();
            string[] nps = fullName.Split(' ');
            FirstName = nps[0];
            LastName = nps[1];
        }
    }
}
