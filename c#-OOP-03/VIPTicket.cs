using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_03
{
    public class VIPTicket : Ticket
    {
        public string LoungeAccess { get; set; }
        public decimal ServiceCharge { get; set; } = 50;

        public VIPTicket(string movieName, decimal price, string loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }
        public override decimal Priceaftertax()
        {
            return base.Priceaftertax() + 20;
        }
        public override string ToString()
        {
            return base.ToString() + " " + LoungeAccess + "VIP";
        }

    }
}