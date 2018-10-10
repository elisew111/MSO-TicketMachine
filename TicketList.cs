using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class TicketList
    {
        public List<Ticket> ticketList = new List<Ticket>();
        public float totalPrice = 0;

        public void AddTicket(Ticket t)
        {
            ticketList.Add(t);
            totalPrice += t.price;
        }

    }
}
