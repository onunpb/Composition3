using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition3.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            Birthdate = birthdate;
        }

        public override string ToString()
        {
            return Name 
                + " (" 
                + Birthdate.ToString("dd/MM/yyyy")
                + ") - " 
                + Email; 
        }
    }
}
