using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage28CS
{
    class ExercisesPage28
    {
        static void Main(string[] args)
        {
            //Exercise 1 Page 28
            string concat = "The directions for exercise 1 say \"Concatenate three strings\" and that is what I am doing here." + "This is the string I am concatenating to the first string." + "This is the third string that I am now adding to the others.";
            Console.WriteLine(concat);
            Console.ReadLine();

            //Exercise 2 Page 28
            string upper = ("this string will appear on the console in all uppercase letters.");
            upper = upper.ToUpper();
            Console.WriteLine(upper);
            Console.ReadLine();

            //Exercise 3 Page 28
            StringBuilder fourAgreements = new StringBuilder();
            fourAgreements.Append("\t A wise man, Don Miguel Ruiz, wrote a book called The Four Agreements.");
            fourAgreements.Append(" The first agreement in this book of wisdom is \"Be impeccable with your word.\"");
            fourAgreements.Append(" The second agreement is \"Don't take anything personally.\"");
            fourAgreements.Append(" The third is \"Don't make assumptions.\"");
            fourAgreements.Append(" Last, but certainly not least, the fourth agreement is \"Always do your best.\"");
            fourAgreements.Append(" This book made me a better person and I continue to remind myself of these four agreements every day.");
            Console.WriteLine(fourAgreements);
            Console.ReadLine();
        }

    }
}
