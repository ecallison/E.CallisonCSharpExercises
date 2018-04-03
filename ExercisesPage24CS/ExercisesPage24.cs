using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage24CS
{
    class ExercisesPage24
    {
        static void Main(string[] args)
        {
            //Exercise 1 on Page 24
            Console.WriteLine("Hello! Are you one of our five current subscribers? If so, please enter the four-digit pin we assigned to you when you set up your account:");
            int score = Convert.ToInt32(Console.ReadLine());
            bool subscriber = score == 1001 || score == 1002 || score == 1003 || score == 1004 || score == 1005;

            while (subscriber == true)
            {
                switch (score)
                {
                    case 1001:
                        Console.WriteLine("Welcome Mary! You are officially logged in!");
                        Console.WriteLine("Would you like to Login as another user? If so, please type in the four-digit pin associated with such user:");
                        score = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1002:
                        Console.WriteLine("Welcome Michael! You are officially logged in!");
                        Console.WriteLine("Would you like to Login as another user? If so, please type in the four-digit pin associated with such user:");
                        score = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1003:
                        Console.WriteLine("Welcome Nickola! You are officially logged in!");
                        Console.WriteLine("Would you like to Login as another user? If so, please type in the four-digit pin associated with such user:");
                        score = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1004:
                        Console.WriteLine("Welcome Erin! You are officially logged in!");
                        Console.WriteLine("Would you like to Login as another user? If so, please type in the four-digit pin associated with such user:");
                        score = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1005:
                        Console.WriteLine("Welcome Connor! You are officially logged in!");
                        Console.WriteLine("Would you like to Login as another user? If so, please type in the four-digit pin associated with such user:");
                        score = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("We have no records of this pin on file.");
                        Console.WriteLine("Please enter your four-digit subscriber pin below:");
                        score = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();

            //Exercise 2 on Page 24
            Console.WriteLine("View your quiz score below by typing in the number of answers you answered correctly out of 5: (Remember, a passing score for quizzes is 50%)");
            int number = Convert.ToInt32(Console.ReadLine());
            bool passed = number == 3 || number == 4 || number == 5;
            do
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("You did not pass this quiz, as your score is 0%.");
                        Console.WriteLine("Because you did not pass, you must take the quiz again. Once you are finished, type in the number of quiz questions you answered correctly out of 5 to view your score:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You did not pass this quiz, as your score is 20%.");
                        Console.WriteLine("Because you did not pass, you must take the quiz again. Once you are finished, type in the number of quiz questions you answered correctly out of 5 to view your score:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You did not pass this quiz, as your score is 40%.");
                        Console.WriteLine("Because you did not pass, you must take the quiz again. Once you are finished, type in the number of quiz questions you answered correctly out of 5 to view your score:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You passed this quiz, as your score is 60%! You do not have to re-take the quiz.");
                        passed = true;
                        break;
                    case 4:
                        Console.WriteLine("You passed this quiz, as your score is 80%! You do not have to re-take the quiz.");
                        passed = true;
                        break;
                    case 5:
                        Console.WriteLine("You passed this quiz, as your score is 100%! You receive a gold star and you do not have to re-take the quiz!");
                        passed = true;
                        break;
                    default:
                        Console.WriteLine("Oops, something went wrong.");
                        Console.WriteLine("Please type in the number of quiz questions you answered correctly out of 5 to view your score:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!passed);

            Console.Read();
        }
    }
}