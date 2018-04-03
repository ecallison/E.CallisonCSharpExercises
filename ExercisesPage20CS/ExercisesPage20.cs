using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePage20CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // PART 1 - Exercise 1 
            Console.WriteLine("Hello there second graders! Please type in any number (and press enter too!) to see what such number multiplied by 50 will come out to!");
            string userNumber1 = Console.ReadLine();
            int userNum1 = Convert.ToInt32(userNumber1);
            int product1 = userNum1 * 50;
            Console.WriteLine(product1);
            Console.ReadLine();

            // PART 1 - Exercise 2
            Console.WriteLine("Hello there first graders! Please type in any number (and press enter too!) to see what such number added to 25 will come out to!");
            string userNumber2 = Console.ReadLine();
            int userNum2 = Convert.ToInt32(userNumber2);
            int product2 = userNum2 + 25;
            Console.WriteLine(product2);
            Console.ReadLine();

            // PART 1 - Exercise 3
            Console.WriteLine("Hello there third graders! Please type in any number (and press enter too!) to see what such number divided by 12.5 will come out to!");
            string userNumber3 = Console.ReadLine();
            double userNum3 = Convert.ToDouble(userNumber3);
            double quotient = userNum3 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            // PART 1 - Exercise 4
            Console.WriteLine("Hello there first graders! Please type in any number (and press enter too!) to see if such number is bigger than 50!");
            string userNumber4 = Console.ReadLine();
            double userNum4 = Convert.ToDouble(userNumber4);
            bool greaterThan = userNum4 > 50;
            Console.WriteLine(greaterThan.ToString());
            Console.ReadLine();

            // PART 1 - Exercise 5
            Console.WriteLine("Hello there fourth graders! Let's Learn about remaineds. Please type in any number (and press enter too!) to see what the remainder would be if you divided such number by 7!");
            string userNumber5 = Console.ReadLine();
            double userNum5 = Convert.ToDouble(userNumber5);
            double remainder = userNum5 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

            //PART 2 - Exercise 1
            bool cSharpAnd = 3 > 2 && 5 > 4;
            Console.WriteLine(cSharpAnd);
            Console.ReadLine();

            //PART 2 - Exercise 2
            bool cSharpOr = 3 > 2 || 5 > 4;
            Console.WriteLine(cSharpOr);
            Console.ReadLine();

            //PART 2 - Exercise 3
            bool cSharpNotEqual = 2 + 2 != 4;
            Console.WriteLine(cSharpNotEqual);
            Console.ReadLine();
        }

    }
}
