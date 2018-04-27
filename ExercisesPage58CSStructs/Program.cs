using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage58CSStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 111.111m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
