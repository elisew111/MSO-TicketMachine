using System;
using System.Windows.Forms;

namespace Lab3
{
    abstract class Purchase
    {

        public abstract void Start();
        public abstract void Pay(float price);
        public abstract void Stop();
        
    }
}
