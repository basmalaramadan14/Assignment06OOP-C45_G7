using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP
{
    public class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(string movie, double price, string seat)
            : base(movie, price)
        {
            Seat = seat;
        }

        public override double FinalPrice() => Price * 1.14; 
    }

    public class VIPTicket : Ticket
    {
        public bool Lounge { get; set; }
        public double Fee { get; set; }

        public VIPTicket(string movie, double price, bool lounge, double fee)
            : base(movie, price)
        {
            Lounge = lounge;
            Fee = fee;
        }

        public override double FinalPrice() => Price + Fee * 1.7; // 200 + 50*1.7 = 285
    }

    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movie, double price, bool is3D)
            : base(movie, price)
        {
            Is3D = is3D;
        }

        public override double FinalPrice() => Price * 1.14; 
    }
}
