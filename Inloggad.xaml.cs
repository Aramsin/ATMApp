using System.Windows;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for Inloggad.xaml
    /// </summary>
    public partial class Inloggad : Window
    {

        Customer _customer;
        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public Inloggad()
        {
            InitializeComponent();
        }


        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            var Deposit = new Deposit();
            Deposit.Show();
            Close();
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Balance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoggingOut_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            this.Close();
            MainWindow.Show();
        }
    }
}
