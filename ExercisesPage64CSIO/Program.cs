using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExercisesPage64CSIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please choose any number!");
            string userNumber = Convert.ToString(Console.ReadLine());
            File.WriteAllText(@"C:\Users\Owner\Desktop\Tech Academy 2018\exercisepg64\log.txt", userNumber);
            string printTextFile = File.ReadAllText(@"C:\Users\Owner\Desktop\Tech Academy 2018\exercisepg64\log.txt");
            Console.WriteLine("\nThe number you chose is {0}.", printTextFile);
            Console.ReadLine();
        }
    }
}
