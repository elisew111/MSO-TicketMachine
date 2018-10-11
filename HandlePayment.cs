using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class HandlePayment
    {
        private Purchase purchase;

        public void setPurchase (Purchase _purchase)
        {
            this.purchase = _purchase;
        }

        public void DoPayment(float price)
        {
            purchase.Start();
            purchase.Pay(price);
            purchase.Stop();
        }
       

    }
}
   //     			switch (info.Payment) {
			//case UIPayment.CreditCard:
			//	CreditCard c = new CreditCard();

			//	break;
			//c
			//
