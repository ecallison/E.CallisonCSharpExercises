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
            Employee1 employee1 = new Employee1();
            Employee2 employee2 = new Employee2();
            employee1.Id = 123;
            employee2.Id = 124;
            int employeeId1 = employee1.Id;
            int employeeId2 = employee2.Id;

            Console.WriteLine("Employee Id already exists in our system: {0}", employeeId1 == employeeId2);
            

            if (employeeId1 == employeeId2)
            {
                Console.WriteLine("We already have a record of the Employee Id {0}. Goodbye!", employeeId1);
            }
            else
            {
                Console.WriteLine("Welcome to Callison Tech!");
            }

            Console.ReadLine();
        }
    }
}
