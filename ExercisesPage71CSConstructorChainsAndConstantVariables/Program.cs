using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage71CSConstructorChainsAndConstantVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises Page 71 Constant Variables/Constructor Chains

            //Exercise 1
            const string myName = "Erin Callison";
            Console.WriteLine("\n{0} is my name and I made it a constant variable :).", myName);
           
            //Exercise 2
            Console.WriteLine("\nHello! Please type something so I can make a variable using the keyword \"var\" please :)!");
            var yourInput = Console.ReadLine();
            Console.WriteLine("\nYay! Thank you! You made \"{0}\" the variable.", yourInput);

            //Exercise 3
            Console.WriteLine("\nNow please enter your name:");
            string yourName = Console.ReadLine();
            Users users = new Users(yourName);
            Console.WriteLine("\nHello {0}. We set your age to the default age of {1}.", yourName, users.Age);
            Console.ReadLine();
        }
    }
}
