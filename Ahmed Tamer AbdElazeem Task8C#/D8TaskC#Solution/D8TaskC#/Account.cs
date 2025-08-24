using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8TaskC_
{
    internal struct Account
    {
        private int id;
        private string holder;
        private double balance;

        public int AccountId
        {
            get { return id; }
            set { id = value; }
        }
        public string AccountHolder
        {
            get { return holder; }
            set { holder = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public Account(int _id, string _holder, double _balance)
        {
            id = _id;
            holder = _holder;
            balance = _balance;
        }

        public override string ToString() 
        {
            return $"Account ID: {id} , Holder: {holder} , Balance: {balance}";
        }

    }
}
