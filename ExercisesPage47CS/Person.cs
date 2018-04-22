using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage47CS
{
    public abstract class Person
    {
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public string firstName { get; set; }
        public string lastName { get; set; }

    }
}
