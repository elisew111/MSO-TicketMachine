using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Purchase
    {
        public void Connect()
        { }
        public void Disconnect()
        { }
        public int BeginTransaction(float amount)
        {
            return 0;
        }
        public bool EndTransaction(int id)
        {
            return false;
        }
        public void CancelTransaction(int id)
        { }

        //c.Connect ();
        //		int ccid = c.BeginTransaction(price);
        //c.EndTransaction (ccid);
    }
}
