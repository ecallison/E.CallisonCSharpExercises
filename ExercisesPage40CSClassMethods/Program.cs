using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage40CSClassMethods
{
    static class Program
    {
        static void Main(string[] args)
        {
            MathEquations math = new MathEquations();

            Console.WriteLine("Hello! Please type in a number to view the quotient of such number divided by 2:");
            Int32.TryParse(Console.ReadLine(), out int userNumber);

            math.DoMath(userNumber);

            math.Answer1DividedByTwo(out int Answer2, userNumber);
            Console.WriteLine("\nAaaand, that new number divided by 2 is: {0}!", Answer2);

            Console.WriteLine("\nOkay, now type in any number to view such number to the third power:\n");
            string userNumber2 = Console.ReadLine();

            double doubleAnswer3 = math.DoMath(userNumber2);

            Console.WriteLine("\nYour number to the third power is: {0}", doubleAnswer3);

            Console.WriteLine("\nNow, type in one more number to see what the third power of such number to the third power is!\n");

            double Answer4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" + Answer4 + " to the third power...to the third power...is: " +  Math.Pow((Math.Pow(Answer4 , StaticClass.myChoice)), 3) + " :)");
            Console.ReadLine();
        }
    }
}
