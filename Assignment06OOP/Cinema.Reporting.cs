using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP
{
    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            int i = 1;
            foreach (var t in tickets)
            {
                string type = t switch
                {
                    StandardTicket => "Standard",
                    VIPTicket => "VIP",
                    IMAXTicket => "IMAX",
                    _ => t.GetType().Name
                };

                string extra = t switch
                {
                    StandardTicket st => $"Seat: {st.Seat}",
                    VIPTicket vip => $"Lounge: {(vip.Lounge ? "Yes" : "No")} | Fee: {vip.Fee}",
                    IMAXTicket imax => $"3D: {(imax.Is3D ? "Yes" : "No")}",
                    _ => ""
                };
                Console.WriteLine($"[Ticket #{i}] {t.Movie} | {type} | {extra} | Price: {t.Price} | Final: {t.FinalPrice():F2} | Booked: {(t.IsBooked ? "Yes" : "No")}");
                i++;
            }
        }
    }
}
