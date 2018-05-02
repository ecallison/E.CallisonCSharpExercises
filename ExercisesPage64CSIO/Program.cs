using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExercisesPage64CSIOANDPage66CSDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises Page 64 IO
            Console.WriteLine("Hello! Please choose any number!");
            string userNumber = Convert.ToString(Console.ReadLine());
            File.WriteAllText(@"C:\Users\Owner\Desktop\Tech Academy 2018\exercisepg64\log.txt", userNumber);
            string printTextFile = File.ReadAllText(@"C:\Users\Owner\Desktop\Tech Academy 2018\exercisepg64\log.txt");
            Console.WriteLine("\nThe number you chose is {0}.\n", printTextFile);
            Console.ReadLine();

            //Exercises Page 66 DateTime/TimeSpan
            Console.WriteLine("Current date and time: {0}", DateTime.Now);
            Console.WriteLine("\nPlease choose any number to view what time it will be in such number of hours!");
            int xHours = Convert.ToInt32(Console.ReadLine());
            DateTime nowPlusXHours = DateTime.Now.AddHours(xHours);
            Console.WriteLine(nowPlusXHours);
            Console.ReadLine();
        }
    }
}
