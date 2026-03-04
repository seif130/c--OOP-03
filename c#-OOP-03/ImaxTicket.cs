using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_03
{
    internal class ImaxTicket : Ticket
    {
        public string ScreenType { get; set; } = "IMAX";
        public ImaxTicket(string movieName, decimal price) : base(movieName, price)
        {
        }
        public override decimal Priceaftertax()
        {
            return base.Priceaftertax() + 30;
        }
        public override string ToString()
        {
            return base.ToString() + " " + ScreenType + "IMAX";
        }
    }
}
