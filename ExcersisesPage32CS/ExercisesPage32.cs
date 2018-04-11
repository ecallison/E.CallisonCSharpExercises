using System;
using System.Collections.Generic;

namespace ExcersisesPage32CS
{
    class ExercisesPage32
    {
        static void Main(string[] args)
        {
            //// Exercise 1 Page 32
            List<int> integerList1 = new List<int>();
            integerList1.Add(222);
            integerList1.Add(111);
            integerList1.Add(22);
            integerList1.Add(11);

            Console.WriteLine("Hello! Please type any number to see what 222 divided by your number, 111 divided by your number, 22 divided by your number, and 11 divided by your number is:");
            int userNumber1 = Convert.ToInt32(Console.ReadLine());

            foreach (int int2211 in integerList1)
            {
                int product1 = int2211 / userNumber1;
                Console.WriteLine(int2211 + " divided by " + userNumber1 + " is " + product1);
            }
            Console.ReadLine();

            // Exercise 2 Page 3
            // When I entered non-zero nnumbers that are bigger than all of the numbers, like 444, for example, the console returned 0 rather than returning the correct integer value.
            // I also noticed that the console rounded the answers when I entered a non-zero number that did not divide evenly into an integer in the list.
            // When I entered non-zero numbers like 12.2 as the user, the console returned nothing. 
            // When I entered -11, however, the console executed the proper mathematic equation and returned the proper products of each integer in the list divided by -11.

            // Exercise 3 Page 32
            // When I entered "0" as the user, the error message that I got was "Exception Unhandled: System.DivideByZeroException: Attempted to divide by zero."

            // Exercise 4 Page 32
            // When I ran the code entering in a string as the number to divide by, the error messages I got was: "Exception Unhandled: System.FormatException: Input string was not in a correct format."

            // Exercise 5 Page 32 - The way this question was phrased (I think there may be a typo in the question) made me question whether I actually completed the exercise properly, but I think this is what it was asking for.
            // If this exercise is asking me to do something else and I didn't understand, I will be happy to re-do this one.
            try
            {
                List<int> integerList2 = new List<int>();
                integerList2.Add(222);
                integerList2.Add(111);
                integerList2.Add(22);
                integerList2.Add(11);

                Console.WriteLine("Hello! Please type a whole number to see what 222 divided by your number, 111 divided by your number, 22 divided by your number, and 11 divided by your number is:");
                int userNumber2 = Convert.ToInt32(Console.ReadLine());

                foreach (int int1122 in integerList2)
                {
                    int product1 = int1122 / userNumber2;
                    Console.WriteLine(int1122 + " divided by " + userNumber2 + " is " + product1);
                }
            }
            catch (FormatException catch1)
            {
                Console.WriteLine("Oops! You typed in a number that is not a whole number!");
            }
            catch (DivideByZeroException catch2)
            {
                Console.WriteLine("Oops! You typed in 0!");
            }
            catch (Exception catch3)
            {
                Console.WriteLine(catch3.Message);
            }
            finally
            {
                Console.WriteLine("\nThis program has emerged from a try catch block. Please try again! Type a whole number to see what 222 divided by your number, 111 divided by your number, 22 divided by your number, and 11 divided by your number is:");
            }
            List<int> integerList3 = new List<int>();
            integerList3.Add(222);
            integerList3.Add(111);
            integerList3.Add(22);
            integerList3.Add(11);
            int userNumber3 = Convert.ToInt32(Console.ReadLine());
            foreach (int int12 in integerList3)
            {
                int product2 = int12 / userNumber3;
                Console.WriteLine(int12 + " divided by " + userNumber3 + " is " + product2);
            }
            Console.ReadLine();
        }
    }
}
