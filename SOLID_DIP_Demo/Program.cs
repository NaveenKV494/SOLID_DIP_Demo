﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DIP_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = new Person
            {
                FirstName = "naveen",
                LastName = "kumar",
                EmailAddress = "naveen@gmail.com",
                PhoneNumber = "7659842310"
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
