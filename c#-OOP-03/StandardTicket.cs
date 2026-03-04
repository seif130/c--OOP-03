using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_03
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }
        public override string ToString()
        {
            return base.ToString() + " " + SeatNumber + "standerd";
        }

    }
}
