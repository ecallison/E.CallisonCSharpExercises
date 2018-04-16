using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage36CSMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Hello! Please enter your favorite number to view the product of such number multiplied by 11, the product of such number multiplied by itself, and the remainder of such number divided by 2:");
            Int32.TryParse(Console.ReadLine(), out int UserNumb);

            int Answer1 = calculator.UserNumberTimes11(UserNumb);
            int Answer2 = calculator.UserNumberTimesItself(UserNumb);
            int Answer3 = calculator.UserNumberRemainder(UserNumb);

            Console.WriteLine("You number multiplied by 11 is: {0}", Answer1);
            Console.WriteLine("\nYou number multiplied by itself is: {0}", Answer2);
            Console.WriteLine("\nWhen you divide your number by 2, the remainder is: {0}", Answer3);

            Console.ReadLine();
        }
    }
}

