﻿using System;
using System.Collections.Generic;


namespace ExercisesPage30CS
{
    class ExercisesPage30
    {
        static void Main(string[] args)
        {
            //// Exercise 1 page 30 CORRECTED
            //Console.WriteLine("Hello! Please enter your first name below to view four affirmations that will make you stronger today!");
            //string userName = Console.ReadLine();
            //string[] affirmations = new string[] { "You are intelligent, ", "You maintain healthy and loving relationships with all of your loved ones, ", "You are happy, grateful, present, and at peace, ", "You are wise and conscientious, " };

            //Console.WriteLine("Below you'll first see the affirmations before your name was entered, then the affirmations with your named added in:\n");
            //for (int i = 0; i < affirmations.Length; i++)
            //{
            //    Console.WriteLine(affirmations[i]);

            //}

            //for (int i = 0; i < affirmations.Length; i++)
            //{
            //    affirmations[i] += userName;
            //    Console.WriteLine(affirmations[i]);

            //}

            //Console.ReadLine();

            ////Exercise 2 on Page 30
            //Console.WriteLine("Hello! Type in your favorite number to see it over and over again");
            //int yourNum = Convert.ToInt32(Console.ReadLine());
            //for (; ; )
            //{
            //    Console.WriteLine(yourNum);
            //}

            ////Exercise 3 on Page 30
            //Console.WriteLine("Hello! Type in your favorite number to see it appear again only once this time (it won't appear infinitely! yay!):");
            //int yourNum2 = Convert.ToInt32(Console.ReadLine());
            //for (int j = 1; j == 1; j++)
            //{
            //    Console.WriteLine(yourNum2);
            //}
            //Console.ReadLine();

            //// Exercise 4 on Page 30
            //Console.WriteLine("Hello Pyschology 101 class. Thank you for taking the IQ score test. You can access your score on our class website by loging in and clicking the \"IQ score\" button. Please find your score amongst all the students' IQ scores below to determine whether or not you are actually considered a genius:");
            //int[] scoreIQ = { 155, 160, 125, 139, 140, 111 };

            //for (int i = 0; i < scoreIQ.Length; i++)
            //{
            //    if (scoreIQ[i] < 140)
            //    {
            //        Console.WriteLine("\n" + scoreIQ[i] + ": Your IQ score does not qualify you as a genius, however, I have observed thoughout this quarter that every student in my class is brilliant, and you are no exception!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\n" + scoreIQ[i] + ": Your IQ score qualifies you as a genius!");
            //    }
            //}
            //Console.ReadLine();

            //// Exercise 5 on Page 30
            //Console.WriteLine("Hello! Please type your favorite number between zero and eleven:");
            //int numberChoice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("I love the number " + numberChoice + ", so much so that I printed it " + numberChoice + " times below:\n");

            //for (int i = 1; i <= (numberChoice); i++)
            //{
            //    Console.WriteLine(numberChoice);
            //}
            //Console.ReadLine();

            //// Exercise 6 on Page 30
            //Console.WriteLine("Hello! Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //string indexNum = Console.ReadLine();

            //List<string> indexString = new List<string>();
            //indexString.Add("zero");
            //indexString.Add("one");
            //indexString.Add("two");
            //for (int i = 0; i < indexString.Count; i++)
            //{
            //    if (indexString[i] == indexNum)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //// Exercise 7 on Page 30
            //Console.WriteLine("Hello! Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //string indexNum2 = Console.ReadLine();
            //List<string> indexString2 = new List<string>();
            //indexString2.Add("zero");
            //indexString2.Add("one");
            //indexString2.Add("two");
            //bool correct = indexNum2 == "zero" || indexNum2 == "one" || indexNum2 == "two";

            //do
            //{
            //    switch (indexNum2)
            //    {
            //        case "zero":
            //            Console.WriteLine(indexString2.IndexOf("zero"));
            //            Console.WriteLine("\nWould you like to try again? Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //            indexNum2 = Console.ReadLine();
            //            break;
            //        case "one":
            //            Console.WriteLine(indexString2.IndexOf("one"));
            //            Console.WriteLine("\nWould you like to try again? Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //            indexNum2 = Console.ReadLine();
            //            break;
            //        case "two":
            //            Console.WriteLine(indexString2.IndexOf("two"));
            //            Console.WriteLine("\nWould you like to try again? Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //            indexNum2 = Console.ReadLine();
            //            break;
            //        default:
            //            Console.WriteLine("Oops! You didn't write either  \"zero,\" \"one,\" or \"two.\"");
            //            Console.WriteLine("\nTry again! Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //            indexNum2 = Console.ReadLine();
            //            break;
            //    }
            //}
            //while (correct == true);
            //Console.ReadLine();

            //// Exercise 8 on Page 30 CORRECTED 
            //Console.WriteLine("Hello! Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //string indexNum3 = Console.ReadLine();
            //List<string> indexString3 = new List<string>();
            //indexString3.Add("zero");
            //indexString3.Add("one");
            //indexString3.Add("two");
            //bool correct2 = indexNum3 == "zero" || indexNum3 == "one" || indexNum3 == "two";

            //do
            //{
            //    switch (indexNum3)
            //    {
            //        case "zero":
            //            Console.WriteLine(indexString3.IndexOf("zero"));
            //            correct2 = false;
            //            break;
            //        case "one":
            //            Console.WriteLine(indexString3.IndexOf("one"));
            //            correct2 = false;
            //            break;
            //        case "two":
            //            Console.WriteLine(indexString3.IndexOf("two"));
            //            correct2 = false;
            //            break;
            //        default:
            //            Console.WriteLine("Oops! You didn't write either  \"zero,\" \"one,\" or \"two.\"");
            //            Console.WriteLine("\nTry again! Please type either \"zero,\" \"one,\" or \"two\" to see the numeric value of such number:");
            //            indexNum3 = Console.ReadLine();
            //            correct2 = true;
            //            break;
            //    }
            //}
            //while (correct2 == true);
            //Console.ReadLine();

            //// Exercise 9 on Page 30
            //Console.WriteLine("Hello! Please type either \"zero,\" \"one,\" \"two,\"or \"three\" to see what indices have such strings in them:");
            //string indexNum4 = Console.ReadLine();

            //List<string> indexString4 = new List<string>();
            //indexString4.Add("indices zero and one");
            //indexString4.Add("indices zero and one");
            //indexString4.Add("indices two and three");
            //indexString4.Add("indices two and three");
            //for (int i = 0; i < indexString4.Count; i++)
            //{
            //    if (indexString4[i].Contains(indexNum4))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //// Exercise 10 on Page 30 - This was the best I could do! I would like to learn a more efficient way to do this if possible!
            //Console.WriteLine("Hello! Please type either \"zero,\" \"one,\" \"two,\"or \"three\" to see what indices have such strings in them:");
            //string indexNum5 = Console.ReadLine();

            //List<string> indexString5 = new List<string>();
            //indexString5.Add("indices zero and one");
            //indexString5.Add("indices zero and one");
            //indexString5.Add("indices two and three");
            //indexString5.Add("indices two and three");

            //int[] zeroOneTwoThree = { 0, 1, 2, 3 };

            //bool correct3 = indexNum5 == "zero" || indexNum5 == "one" || indexNum5 == "two" || indexNum5 == "three";

            //do
            //{
            //    switch (indexNum5)
            //    {
            //        case "zero":
            //            Console.WriteLine(zeroOneTwoThree[0]);
            //            Console.WriteLine(zeroOneTwoThree[1]);
            //            Console.WriteLine("\nWould you like to try again? Please type either \"zero,\" \"one,\" \"two,\"or \"three\" to see what indices have such strings in them:");
            //            indexNum5 = Console.ReadLine();
            //            break;
            //        case "one":
            //            Console.WriteLine(zeroOneTwoThree[0]);
            //            Console.WriteLine(zeroOneTwoThree[1]);
            //            Console.WriteLine("\nWould you like to try again? Please type either \"zero,\" \"one,\" \"two,\"or \"three\" to see what indices have such strings in them:");
            //            indexNum5 = Console.ReadLine();
            //            break;
            //        case "two":
            //            Console.WriteLine(zeroOneTwoThree[2]);
            //            Console.WriteLine(zeroOneTwoThree[3]);
            //            Console.WriteLine("\nWould you like to try again? Please type either \"zero,\" \"one,\" \"two,\"or \"three\" to see what indices have such strings in them:");
            //            indexNum5 = Console.ReadLine();
            //            break;
            //        case "three":
            //            Console.WriteLine(zeroOneTwoThree[2]);
            //            Console.WriteLine(zeroOneTwoThree[3]);
            //            Console.WriteLine("\nWould you like to try again? Please type either \"zero,\" \"one,\" \"two,\"or \"three\" to see what indices have such strings in them:");
            //            indexNum5 = Console.ReadLine();
            //            break;
            //        default:
            //            Console.WriteLine("Oops! You didn't write either  \"zero,\" \"one,\" \"two,\" or \"three.\"");
            //            Console.WriteLine("\nTry again! Please type either \"zero,\" \"one,\" \"two,\"or \"three\" to see what indices have such strings in them:");
            //            indexNum5 = Console.ReadLine();
            //            break;

            //    }
            //}
            //while (correct3 == true);
            //Console.ReadLine();

            // Exercise 11 on Page 30 - CORRECTED!!!!!! :)
            List<string> positiveAffirmations = new List<string>() { "I am focused.", "I am calm.", "I am intelligent.", "I am focused.", "I am calm.", "I am intelligent." , "I am at peace."};
            List<string> newList = new List<string>();

            foreach (string Iam in positiveAffirmations)
            {
                Console.WriteLine(Iam);
                if (newList.Contains(Iam))
                {
                    Console.WriteLine("This affirmation has already appeared in this list.");
                }
                else
                {
                    Console.WriteLine("This affirmation is appearing for the first time in this list.");
                }
                newList.Add(Iam);  
            }
            Console.ReadLine();
        }
    }
}
