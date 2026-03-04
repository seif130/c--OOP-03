using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_03
{
    internal class ImaxTicket : Ticket
    {
        public bool  Is3d { get; set; } 
        public ImaxTicket(string movieName, decimal price , bool is3d) : base(movieName, price)
        {
            Is3d = is3d;

            if (is3d) price += 30;

        }
        public override decimal Priceaftertax()
        {
            return base.Priceaftertax() + 30;
        }
        public override string ToString()
        {
            return base.ToString() + " "  + "IMAX" + Is3d ;
        }
    }
}
