using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public class Transaction
    {
        public int transactionID { get; set; }
        public int amount { get; set; }
        public bool isDeposit { get; set; }
        public DateTime dateTime { get; set; }

        public Transaction(int transactionID, int amount, bool isDeposit, DateTime dateTime)
        {
            this.transactionID = transactionID;
            this.amount = amount;
            this.isDeposit = isDeposit;
            this.dateTime = dateTime;
        }

    }
}
