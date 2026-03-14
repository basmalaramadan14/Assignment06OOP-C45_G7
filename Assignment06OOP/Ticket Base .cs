using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP
{
    
        public abstract class Ticket
        {
            public string Movie { get; set; }
            public double Price { get; set; }
            public bool IsBooked { get; private set; }

            public Ticket(string movie, double price)
            {
                Movie = movie;
                Price = price;
            }

            public void Book() => IsBooked = true;

            public abstract double FinalPrice();  
        }
    }
