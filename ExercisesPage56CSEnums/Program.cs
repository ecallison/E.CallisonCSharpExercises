 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage56CSEnums
{
    class Program
    {
        static void Main(string[] args)
        {


            foreach (Week.DaysOfTheWeek day in Enum.GetValues(typeof(Week.DaysOfTheWeek)))
            {
                try
                {
                    Console.WriteLine("Please enter the current day of the week:");
                    string userDay = Console.ReadLine();
                    bool result = Int32.TryParse(userDay, out int num);
                    if (result)
                    {
                        Console.WriteLine("\nPlease enter an actual day of the week.\n");
                    }
                    else
                    {
                        Week.DaysOfTheWeek correctDay = (Week.DaysOfTheWeek)Enum.Parse(typeof(Week.DaysOfTheWeek), userDay);
                        Console.WriteLine("Yes! You're right! Today is {0}!", (Week.DaysOfTheWeek)correctDay, correctDay.ToString());
                        Console.ReadLine();
                        return;
                    }

                }
                catch (FormatException ex1)
                {
                    Console.WriteLine("\nPlease enter an actual day of the week.\n");
                }
                catch (ArgumentException ex2)
                {
                    Console.WriteLine("\nPlease enter an actual day of the week.\n");
                }
                catch (InvalidCastException ex3)
                {
                    Console.WriteLine("\nPlease enter an actual day of the week.\n");
                }
                catch (Exception ex4)
                {
                    Console.WriteLine("\nPlease enter an actual day of the week.\n");
                }
            }
           
        }
    }
}