using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage37CSMoreOnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();
            
            //Integer Math Operation
            Console.WriteLine("Hello! Please enter your favorite number to view the product of such number multiplied by itself:");
            Int32.TryParse(Console.ReadLine(), out int IntegerOperation);

            int integerAnswer = mathOperations.Calculate(IntegerOperation);

            Console.WriteLine("Your number multiplied by itself is: {0}", integerAnswer);

            //Decimal Math Operation
            Console.WriteLine("\nOkay, now type in any decimal number to view the quotient of such decimal number divided by 2:");

            Decimal.TryParse(Console.ReadLine(), out decimal DecimalOperation);

            decimal decimalAnswer = mathOperations.Calculate(DecimalOperation);

            Console.WriteLine("You number divided by 2 is: {0}", decimalAnswer);

            //String to Integer Math Operation
            Console.WriteLine("\nOkay, now type in any number to view such number multiplied by 1,111:");
            string StringToIntOperation = Console.ReadLine();

            double stringToIntAnswer = mathOperations.Calculate(StringToIntOperation);

            Console.WriteLine("\nYou number multiplied by 1,111 is: {0}", stringToIntAnswer);
         
            Console.ReadLine();

            //The following chunk of code refers to an extra method I created just for fun to do a more complex math operation involving doubles
            //Console.WriteLine("\nOkay, now type in any number to view such number to the third power:");
            //string StringToIntOperation = Console.ReadLine();

            //double stringToIntAnswer = mathOperations.Calculate(StringToIntOperation);

            //Console.WriteLine("\nYou number to the third power is: {0}", stringToIntAnswer);

            //Console.ReadLine();
        }
    }
}
