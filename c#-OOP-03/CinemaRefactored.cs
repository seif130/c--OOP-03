using c__OOP_03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaRefactored
{
   
       
    public class Cinema
    {
        private string CinemaName { get; set; }
        private Projector Projector;
        private Ticket[] Tickets = new Ticket[20];
        private int ticketCount = 0;

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            Projector = new Projector();
        }

        public void startcinema()
        {
            Console.WriteLine($"{CinemaName} is starting.");
            Projector.start();
        }

        public void stopcinema()
        {
            Console.WriteLine($"{CinemaName} is stopping.");
            Projector.stop();
        }

        public bool  AddTicket(Ticket ticket)
        {
            if (ticketCount < Tickets.Length)
            {
                Tickets[ticketCount++] = ticket;
                return true;
            }
            else
            {
                Console.WriteLine("No more tickets can be added.");
                return false;
            }
        }

        public void PrintTickets()
        {
            Console.WriteLine($"Tickets for {CinemaName}:");
            for (int i = 0; i < ticketCount; i++)
            {
                Console.WriteLine(Tickets[i].ToString());
            }
        }


    }


}
