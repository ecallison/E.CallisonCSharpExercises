using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage73CSExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age:");
                int userAge = Convert.ToInt32(Console.ReadLine());
                bool correctAge = userAge <= 0;
                if (correctAge)
                {
                    throw new ZeroOrNegativeException();
                }

                int getYearBorn = 2018 - userAge;
                Console.WriteLine("You were born in {0}.", getYearBorn);
                Console.ReadLine();
                return;
            }
            catch (ZeroOrNegativeException a)
            {
                Console.WriteLine("Please do not enter a negative number or a zero silly. Please enter your age in digits (with no decimals).");
            }
            catch (ArgumentException b)
            {
                Console.WriteLine("Please enter simply your age in digits. Please do not type, for example, \"18 years\".");
            }
            catch (Exception c)
            {
                Console.WriteLine("Please enter simply your age in digits (no negative numbers or decimals please). Please do not type, for example, \"18 years\".");
            }
            Console.ReadLine();
        }
    }
}
    
