using System;
using System.Windows;


namespace ATMApp
{
    
    public partial class Deposit : Window
    {
        Customer _customer;

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public Deposit(Customer customer)
        {
            InitializeComponent();
            AccountBalance.Text = GetAccountBalance(customer);
        }

        private string GetAccountBalance(Customer customer)
        {
            _customer = customer;
            var result = customer.GetBalance().ToString();
            return result;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            var Inloggad = new Inloggad(_customer);
            Inloggad.Show();
            Close();
        }

        private void ConfirmDepositBtn_Click(object sender, RoutedEventArgs e)
        {
            string depositAmountString = DepositAmount.Text;
            int depositAmount = Convert.ToInt32(depositAmountString);
            Transaction transaction = new Transaction(1, depositAmount, true, DateTime.Now, 999, 888);
        }

    }
}
