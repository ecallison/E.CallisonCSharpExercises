using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage49CSInterfaces
{
    class Employee: IQuittable
    {
        public void Quittable()
        {
            Console.WriteLine("Your first and last name has been removed from your employee file. Goodbye.");
        }
    }
}
