using System;
using System.Windows.Forms;

namespace Lab3
{
    class IKEAAdapter : IKEAMyntAtare2000
    {
        public void Connect()
        {
            starta();
        }

        public void Disconnect()
        {
            stoppa();
        }

        public int BeginTransaction(float amount)
        {
            betala((int) amount);
            return 1;
        }
        public bool EndTransaction(int id)
        {
            if (id != 1)
                return false;

            MessageBox.Show("End transaction 1");
            return true;
        }
        public void CancelTransaction(int id)
        {
            if (id != 1)
                throw new Exception("Incorrect transaction id");

            MessageBox.Show("Cancel transaction 1");
        }

        public void Buy(float price)
        {
            Connect();
            int id = BeginTransaction(price);
            EndTransaction(id);
        }
    }
}
