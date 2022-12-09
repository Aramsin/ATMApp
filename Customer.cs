using System.Collections.Generic;

namespace ATMApp
{
    public class Customer
    {

        public string? name { get; set; } 

        public int pinCode { get; set; }

        public int accountNr { get; set; }

        public double balance { get; set; }

        public List<Customer> customer = new List<Customer>();
        public List<Customer> CustomerList()
        {
            customer.Add(new Customer() { name = "Poor Peggy", accountNr = 999, pinCode = 999, balance = 1000 });
            customer.Add(new Customer() { name = "Sleepy Joe", accountNr = 888, pinCode = 888, balance = 43000 });
            customer.Add(new Customer() { name = "Lucky Luke", accountNr = 777, pinCode = 777, balance = 155210.70 });
            customer.Add(new Customer() { name = "Luci DeVol", accountNr = 666, pinCode = 666, balance = 6666666 });
            return customer;
        }
        public int GetAccountNr() { return accountNr; }
        public string? GetName() { return name; }
        public int GetPinCode() { return pinCode; }
        public double GetBalance() { return balance; }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }



    }
}