using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage60CSLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();


            //Exercise 1 Page 60
            List<Employee> EmployeeList = new List<Employee>
            {
                new Employee { FirstName = "Erin", LastName = "Callison", Id = 111},
                new Employee { FirstName = "Allie", LastName = "Aiello", Id = 112},
                new Employee { FirstName = "Dr. Wayne", LastName = "Dyer", Id = 113},
                new Employee { FirstName = "Joe", LastName = "Campbell", Id = 114},
                new Employee { FirstName = "Joe", LastName = "Uncle", Id = 115},
                new Employee { FirstName = "Jordan", LastName = "Peterson", Id = 116},
                new Employee { FirstName = "Joe", LastName = "Love", Id = 117},
                new Employee { FirstName = "Paulo", LastName = "Coelho", Id = 118},
                new Employee { FirstName = "Louise", LastName = "Hay", Id = 119},
                new Employee { FirstName = "Deepak", LastName = "Chopra", Id = 120},
            };


            ////Exercise 2 Page 60
            List<Employee> newList1 = new List<Employee>();

            foreach (Employee emp in EmployeeList)
            {

                if (emp.FirstName == "Joe")
                {
                    newList1.Add(emp);
                    Console.WriteLine(emp.FirstName.ToString()); //when I typed  Console.WriteLine(newList.ToString()); , it generated an error. Can you just convert the list elements to a string and print a list like this to the console?
                }

            }

            //Exercise 3 Page 60
            List<Employee> newList2 = EmployeeList.Where(x => x.FirstName == ("Joe")).ToList(); 


            //Exercise 4 Page 60
            List<Employee> newList3 = EmployeeList.Where(y => y.Id > 5).ToList();

            foreach (Employee newEmp in newList3)
            {
                Console.WriteLine(newEmp.Id.ToString()); //Same thing here: I tried typing "Console.WriteLine(newList3.ToString());" and it didn't run. Just curious if there is a better way to print this than what I ended up doing here
            }

            Console.ReadLine();
        }
    }
}
