using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage34CS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            List<string> Tickets = new List<string>()
            {
                "This is not the winning lottery ticket. Try again!" , "You chose the winning lottery ticket! You win $6 billion!", "This is not the winning lottery ticket. Try again!"
            };

            foreach (string ticketMessage in Tickets)
            {
                LTicket1 ticket1 = new LTicket1();
                LTicket2 ticket2 = new LTicket2();
                LTicket3 ticket3 = new LTicket3();
                ticket1.LNum1 = ticketMessage;
                ticket2.LNum2 = ticketMessage;
                ticket3.LNum3 = ticketMessage;

            }

            Console.WriteLine("Hello! Please type in either 1, 2, or 3 to pick from 3 lottery tickets (and to view the class of such ticket). If you choose the winning ticket, you will win $6 billion (good luck!):");
            int userTicket = Convert.ToInt32(Console.ReadLine());

            if (userTicket == 1)
            {
                Console.WriteLine("You chose the class LTicket1.\n");
                Console.WriteLine(Tickets[0]);
            }
            else if (userTicket == 2)
            {
                Console.WriteLine("You chose the class LTicket2.\n");
                Console.WriteLine(Tickets[1]);
            }
            else if (userTicket == 3)
            {
                Console.WriteLine("You chose the class LTicket3.\n");
                Console.WriteLine(Tickets[2]);
            }

            Console.ReadLine();
        }

        
        

    }
}
