using System;
using System.Collections.Generic;
using System.Text;

namespace CourseComposicaoRquest.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + BirthDate.ToString("dd/MM/YYYY")
            + ") - "
            + Email;
        }
    }
}
