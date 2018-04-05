using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage28C.S
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 page 28
            Console.WriteLine("Hello! Please type either 0, 1, 2, or 3 below to view one of 4 wise quotes:");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            string[] stringArray1 = { "\"What you seek is seeking you\" -Rumi", "\"As you think, so you shall become\" -Bruce Lee", "\"You are what you believe yourself to be\" -Paulo Coelho", "\"Each time you send love in response to hate, you diffuse the hate\" -Dr. Wayne Dyer" };
            Console.WriteLine(stringArray1[userChoice]);
            Console.ReadLine();

            //Exercise 2 page 28
            Console.WriteLine("Hello! Please type either 0, 1, 2, or 3 below to view one of my 4 favorite numbers:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int[] numArray1 = { 11, 22, 17, 28 };
            Console.WriteLine(numArray1[userNumber]);
            Console.ReadLine();

            //Exercise 3 page 28
            Console.WriteLine("Hello! Please type either 0, 1, 2, or 3 below to view one of my 4 favorite numbers:");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());
            int[] numArray2 = { 11, 22, 17, 28 };

            if (userNumber2 == 0 || userNumber2 == 1 || userNumber2 == 2 || userNumber2 == 3)
            {
                Console.WriteLine(numArray2[userNumber2]);
            }
            else if (userNumber2 != 0 || userNumber2 != 1 || userNumber2 != 2 || userNumber2 != 3)
            {
                Console.WriteLine("Ooooops! You typed something other than 0, 1, 2, or 3. Please type one of these numbers below if you would like to view one of my 4 favorite numbers:");
                int userNumber3 = Convert.ToInt32(Console.ReadLine());
                int[] numArray3 = { 11, 22, 17, 28 };
                Console.WriteLine(numArray3[userNumber3]);
            }

            Console.ReadLine();

            //Exercise 4 page 28
            Console.WriteLine("Hello! Please type either 0, 1, 2, 3, or 4 below to view one of five fortunes. Whichever you choose will be the right guidance for you today:");
            int indexChoice = Convert.ToInt32(Console.ReadLine());

            List<string> stringList = new List<string>();
            stringList.Add("Feeling the energy of the earth will help you feel more grounded today. Take off your shoes and put your bare feet in the grass. Feel the powerful energy you receive from the earth.");
            stringList.Add("Forgive yourself for those things you did when you were not as wise as you are now. Take a moment to remember where you were 5 years ago and reflect on how far you have come/grown");
            stringList.Add("Think of someone or something right now that brightens your life. Take 30 seconds to give thanks for this gift.");
            stringList.Add("Do your best to judge nothing and no one just for today.");
            stringList.Add("Meditate today on the wise words from Aunte Wu from the show Avatar: The Last Airbender\n\"If you follow your heart, you'll be with the one you love.\"");

            Console.WriteLine(stringList[indexChoice]);
            Console.ReadLine();

        }
    }
    
}
