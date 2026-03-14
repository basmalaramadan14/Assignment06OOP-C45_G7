using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP
{
    public static class TicketExtensions
    {
        
        public static string Receipt(this Ticket t)
        {
            return
$@"========== RECEIPT ==========
  Movie    : {t.Movie}
  Type     : {t.GetType().Name}
  Price    : {t.Price}
  Final    : {t.FinalPrice():F2}
  Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
=============================";
        }

        public static double TotalRevenue(this IEnumerable<Ticket> tickets) =>
            tickets.Sum(t => t.FinalPrice());
    }
}
