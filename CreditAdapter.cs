using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class CreditAdapter : Purchase
    {
        CreditCard credit = new CreditCard();

        public override void Start()
        {
            credit.Connect();
        }

        public override void Pay(float price)
        {
            credit.BeginTransaction(price+0.5f);
        }

        public override void Stop()
        {
            credit.Disconnect();
        }
    }
}
