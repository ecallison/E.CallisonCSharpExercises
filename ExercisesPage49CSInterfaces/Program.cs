using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage49CSInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            quittable.Quittable();
            Console.ReadLine();
        }
    }
}
