using System;
using System.Windows.Forms;

namespace Lab3
{
    class IKEAAdapter : Purchase
    {
        IKEAMyntAtare2000 ikea = new IKEAMyntAtare2000();

        public override void Start()
        {
            ikea.starta();
        }

        public override void Pay(float price)
        {
            ikea.betala((int)price);
        }

        public override void Stop()
        {
            ikea.stoppa();
        }
    }
}
