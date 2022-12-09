using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    public class Transaction : Customer
    {
        Customer _customer;
        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public int transactionID { get; set; }
        public int accountSender { get; set; }
        public int accountReciever { get; set; }
        public int amount { get; set; }
        public bool isDeposit { get; set; }
        public DateTime dateTime { get; set; }
        

        public Transaction(int transactionID, int amount, bool isDeposit, DateTime dateTime, int accountReciever, int accountSender)
        {
            this.transactionID = transactionID;
            this.amount = amount;
            this.isDeposit = isDeposit;
            this.dateTime = dateTime;
            this.accountReciever = accountReciever;
            this.accountSender = accountSender;
        }

        public Transaction(Customer customer)
        {
            double balance = _customer.GetBalance();
            _customer.SetBalance(balance += amount);
        }

    }
}
