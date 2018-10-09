using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticket
    {
        public float price;
        private UIClass klasse;
        private UIDiscount discount;
        private string destination;
        private string origin;
        private UIWay way;


        public Ticket(UIInfo info)
        {
            klasse = info.Class;
            discount = info.Discount;
            destination = info.To;
            origin = info.From;
            way = info.Way;

            GetPrice g = new GetPrice(klasse, discount, destination, origin, way);
            price = g.ReturnPrice();

        }
        
    }
}
