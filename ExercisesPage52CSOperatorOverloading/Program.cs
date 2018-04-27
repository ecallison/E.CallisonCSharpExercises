using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage52CSOperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 123;
            employee2.Id = 123;

            if (employee1 == employee2)
            {
                Console.WriteLine("Record of employee Id {0} already exists. Goodbye!", employee1.Id);
            }
            else
            {
                Console.WriteLine("Thank you for submitting your unique employee Id. Welcome to Callison Tech!");
            }

            Console.ReadLine();
        }
    }
}
