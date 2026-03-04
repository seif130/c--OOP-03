using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_03
{
    public class Ticket
    {
        private static int _ticketCounter = 0;
        public int Ticketid { get; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }

        public Ticket(string movieName, decimal price)
        {
            Ticketid = ++_ticketCounter;
            MovieName = movieName;
            Price = price > 0 ? price : 0;
        }

        public virtual decimal Priceaftertax()
        {
            return Price * 1.14m;
        }
        public static int GetTotalTickets()
        {
            return _ticketCounter;
        }

        public override string ToString()
        {
            return $"Ticket ID: {Ticketid}, Movie: {MovieName}, Price: {Price:C}, Price after tax: {Priceaftertax():C}";
        }
    }
}
