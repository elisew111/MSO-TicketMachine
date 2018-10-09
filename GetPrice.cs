using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class GetPrice
    {
        float price;
        public GetPrice(UIClass klasse, UIDiscount discount, String destination, String origin, UIWay way)
        {
            // Get number of tariefeenheden
            int tariefeenheden = Tariefeenheden.getTariefeenheden(origin, destination);

            // Compute the column in the table based on choices
            int tableColumn;
            // First based on class
            switch (klasse)
            {
                case UIClass.FirstClass:
                    tableColumn = 3;
                    break;
                default:
                    tableColumn = 0;
                    break;
            }
            // Then, on the discount
            switch (discount)
            {
                case UIDiscount.TwentyDiscount:
                    tableColumn += 1;
                    break;
                case UIDiscount.FortyDiscount:
                    tableColumn += 2;
                    break;
            }

            // Get price
            price = PricingTable.getPrice(tariefeenheden, tableColumn);
            if (way == UIWay.Return)
            {
                price *= 2;
            }

        }
        public float ReturnPrice()
        {
            return price;
        }

        
    }
}
