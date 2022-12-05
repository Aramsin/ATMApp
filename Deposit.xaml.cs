using System.Windows;


namespace ATMApp
{
    /// <summary>
    /// Interaction logic for Deposit.xaml
    /// </summary>
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
            var result = customer.GetBalance().ToString();
            return result;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            var Inloggad = new Inloggad();
            this.Close();
            Inloggad.Show();
        }

        private void ConfirmDepositBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
