using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage22CS
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Excercise 1 Page 22
            //int myAnnualIncome = 200000000;
            //int averageAnnualIncome = 72824;
            //bool success = myAnnualIncome > averageAnnualIncome;



            //if (success == true)
            //{
            //    Console.WriteLine("You made more money this year than the average individual with an advanced degree! Well done you!");
            //}
            //Console.ReadLine();

            ////Excercise 2 Page 22
            //Console.WriteLine("Hey there! Test your telepathy skills and guess what number I am thinking of right this second? (hint: it's between 0 and 5000)");
            //int myNumber = 4218;
            //int userNum = Convert.ToInt32(Console.ReadLine());
            //bool telepathy = myNumber == userNum;


            //if (telepathy == true)
            //{
            //    Console.WriteLine("You guessed the number in I was thinking of(4218)! Wow, you have psychic telepathic gifts!Congratulations!");
            //}
            //else if (telepathy == false)
            //{
            //    Console.WriteLine("You did not guess the number I was just thinking of, but with just a little practice, you can strengthen psychic abilities! Keep practicing and don't give up :).");
            //}
            //Console.ReadLine();

            ////EXERCISE 3 Page 22
            Console.WriteLine("Are you elligible to view the content of our website? Please type your age to determine if this is true:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            bool elligible = userAge >= 18 ? true : false;
            Console.WriteLine(elligible);
            Console.ReadLine();
        }
    }
}
