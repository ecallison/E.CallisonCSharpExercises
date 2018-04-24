using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage54CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string>() { "Employee Email Address: erinjccallison@yahoo.com", "Employee Phone Number: 1(916)953-3225", "Employee Position: Senior Developer" };
            
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int>() { 123, 1111, 67, 800000};

            foreach (string i in employeeString.Things)
            {
                Console.Write("{0}\n", i.ToString());
            }

            foreach (int j in employeeInt.Things)
            {
                Console.Write("\nClassified Employee Figures: {0}", j.ToString());
            }

            Console.ReadLine();


        }
    }
}
