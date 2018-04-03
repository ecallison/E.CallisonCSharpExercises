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
            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);
            int product = userNum * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            //// PART 1 - Exercise 2
            //Console.WriteLine("Hello there first graders! Please type in any number (and press enter too!) to see what such number added to 25 will come out to!");
            //string userNumber = Console.ReadLine();
            //int userNum = Convert.ToInt32(userNumber);
            //int product = userNum + 25;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //// PART 1 - Exercise 3
            //Console.WriteLine("Hello there third graders! Please type in any number (and press enter too!) to see what such number divided by 12.5 will come out to!");
            //string userNumber = Console.ReadLine();
            //double userNum = Convert.ToDouble(userNumber);
            //double quotient = userNum / 12.5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //// PART 1 - Exercise 4
            //Console.WriteLine("Hello there first graders! Please type in any number (and press enter too!) to see if such number is bigger than 50!");
            //string userNumber = Console.ReadLine();
            //double userNum = Convert.ToDouble(userNumber);
            //bool greaterThan = userNum > 50;
            //Console.WriteLine(greaterThan.ToString());
            //Console.ReadLine();

            //// PART 1 - Exercise 5
            //Console.WriteLine("Hello there fourth graders! Let's Learn about remaineds. Please type in any number (and press enter too!) to see what the remainder would be if you divided such number by 7!");
            //string userNumber = Console.ReadLine();
            //double userNum = Convert.ToDouble(userNumber);
            //double remainder = userNum % 7;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            ////PART 2 - Exercise 1
            //bool cSharpAnd = 3 > 2 && 5 > 4;
            //Console.WriteLine(cSharpAnd);
            //Console.ReadLine();

            ////PART 2 - Exercise 2
            //bool cSharpOr = 3 > 2 || 5 > 4;
            //Console.WriteLine(cSharpOr);
            //Console.ReadLine();

            ////PART 2 - Exercise 3
            //bool cSharpNotEqual = 2 + 2 != 4;
            //Console.WriteLine(cSharpNotEqual);
            //Console.ReadLine();
        }

    }
}
