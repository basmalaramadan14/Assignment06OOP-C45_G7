using Assignment06OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP
{
    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket t) => tickets.Add(t);

        public void BookAll()
        {
            Console.WriteLine("=== Cinema Opened ===\n Projector ON\n");
            foreach (var t in tickets)
                t.Book();
        }

        public void Close()
        {
            Console.WriteLine("\nProjector OFF");
            Console.WriteLine("=== Cinema Closed ===");
        }
    }
}