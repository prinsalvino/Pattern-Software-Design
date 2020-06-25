using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
            Console.ReadKey();
        }
        void Start()
        {
            TicketSystem ticketSystem = TicketSystem.GetTicket();
            ticketSystem.DisplayAllTickets();
            Console.WriteLine();

            //Ticket System 1
            PrintHeader("[Ticket System 1]");
            ticketSystem.SellTickets("Bruno Mars",10);
            ticketSystem.DisplayAllTickets();

            //Ticket System 2
            Console.WriteLine();
            PrintHeader("[Ticket System 2]");
            TicketSystem ticketSystem2 = TicketSystem.GetTicket();
            ticketSystem2.SellTickets("Coldplay", 50);
            ticketSystem2.DisplayAllTickets();

            //Ticket System 3
            Console.WriteLine();
            PrintHeader("[Ticket System 3]");
            TicketSystem ticketSystem3 = TicketSystem.GetTicket();
            ticketSystem3.SellTickets("Ed Sheeran", 100);
            ticketSystem3.DisplayAllTickets();
        }
        void PrintHeader(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.ResetColor();
        }
    }
}
