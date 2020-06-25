using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class TicketSystem
    {
        private static TicketSystem ticketSystem;
        Dictionary<string, int> tickets;
        private TicketSystem()
        {
            tickets = new Dictionary<string, int>();
            tickets.Add("Bruno Mars", 250);
            tickets.Add("Coldplay", 175);
            tickets.Add("Ed Sheeran", 150);
        }
        public static TicketSystem GetTicket()
        {
            if (ticketSystem == null)
            {
                ticketSystem = new TicketSystem();
            }
            return ticketSystem;
        }
        public void DisplayAllTickets()
        {
            foreach (KeyValuePair<string, int> item in tickets)
            {
                Console.WriteLine($"Artist: {item.Key} has {item.Value} tickets left");
            }
        }
        public void SellTickets(string artist, int count)
        {
            foreach (KeyValuePair<string, int> item in tickets.ToList())
            {
                if (item.Key == artist)
                {
                    tickets[item.Key] = item.Value - count;
                }
            }
            Console.WriteLine($"Customer buy ticket for {artist}, {count}x");
        }
    }
}
