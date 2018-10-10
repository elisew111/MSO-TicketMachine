using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class HandlePayment
    {

        public HandlePayment(UIInfo info, TicketList TL)
        {

            float price = TL.totalPrice;

            switch (info.Payment)
            {
                case UIPayment.CreditCard:
                    CreditPurchase cp = new CreditPurchase();
                    cp.Buy(price + 0.5f);
                    break;
                case UIPayment.DebitCard:
                    DebitPurchase dp = new DebitPurchase();
                    dp.Buy(price);
                    break;
                case UIPayment.Cash:
                    IKEAAdapter ikea = new IKEAAdapter();
                    ikea.Buy(price);

                    break;
                default: break;
            }

        }

    }
}
   //     			switch (info.Payment) {
			//case UIPayment.CreditCard:
			//	CreditCard c = new CreditCard();

			//	break;
			//c
			//
