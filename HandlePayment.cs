using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class HandlePayment
    {

        public HandlePayment(UIInfo info)
        {
            switch (info.Payment)
            {
                case UIPayment.CreditCard:
                    //CreditPurchase();
                    break;
                case UIPayment.DebitCard:
                    //DebitPurchase();
                    break;
                case UIPayment.Cash:
                    //CoinPurchase();

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
