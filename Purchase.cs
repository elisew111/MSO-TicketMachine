﻿using System;
using System.Windows.Forms;

namespace Lab3
{
    class Purchase
    {
        protected string name;


        public void Connect()
        {
            MessageBox.Show("Connecting to " + name);
        }

        public void Disconnect()
        {
            MessageBox.Show("Disconnecting from " + name);
        }
        public int BeginTransaction(float amount)
        {
            MessageBox.Show("Begin transaction 1 of " + amount + " EUR");
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

        public void Buy (float price)
        {
            Connect();
            int id = BeginTransaction(price);
            EndTransaction(id);
        }
        
    }
}
