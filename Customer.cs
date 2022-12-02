namespace ATMApp
{
    internal class Customer
    {

        private string name;
        private int pinCode;
        private int accountNr;
        private double balance;


        public int GetAccountNr()
        {
            return accountNr;
        }

        public int GetPinCode()
        {
            return pinCode;
        }

        public Customer(string name, int accountNr, int pinCode, double balance)
        {
            this.name = name;
            this.pinCode = pinCode;
            this.accountNr = accountNr;
            this.balance = balance;
        }
    }
}
