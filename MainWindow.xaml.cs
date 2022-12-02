using System.Windows;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer customer1 = new Customer(name: "Poor Peggy", accountNr: 999, pinCode: 999, balance: 10);
        Customer customer2 = new Customer(name: "Average Joe", accountNr: 117, pinCode: 117, balance: 17000);
        Customer customer3 = new Customer(name: "Lucky Luke", accountNr: 1234, pinCode: 1234, balance: 344000);

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (userInputAccountNumber.Text == customer1.GetAccountNr().ToString() && userInputPincodeNumber.Password == customer1.GetPinCode().ToString() ||
                userInputAccountNumber.Text == customer2.GetAccountNr().ToString() && userInputPincodeNumber.Password == customer2.GetPinCode().ToString() ||
                userInputAccountNumber.Text == customer3.GetAccountNr().ToString() && userInputPincodeNumber.Password == customer3.GetPinCode().ToString())
            {
                MessageBox.Show("You are logged in!");
                var inloggad = new Inloggad();
                inloggad.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong accountnumber or password. Please try again!");
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
