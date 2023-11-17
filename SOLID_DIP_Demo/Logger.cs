using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DIP_Demo
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
