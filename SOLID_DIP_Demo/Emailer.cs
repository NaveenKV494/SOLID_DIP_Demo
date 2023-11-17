using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DIP_Demo
{
    public class Emailer
    {
        public void SendEmail(Person person, string message)
        {
            Console.WriteLine($"Sending an email to {person.EmailAddress}");
        }
    }
}
