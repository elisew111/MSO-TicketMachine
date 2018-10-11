using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class DebitAdapter : Purchase
    {
        DebitCard debit = new DebitCard();

        public override void Start()
        {
            debit.Connect();
        }

        public override void Pay(float price)
        {
            debit.BeginTransaction(price);
        }

        public override void Stop()
        {
            debit.Disconnect();
        }
    }
}
