using System.Windows;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Customer customer1 = new Customer(name: "Poor Peggy", accountNr: 999, pinCode: 999, balance: 10);
         Customer customer2 = new Customer(name: "Average Joe", accountNr: 117, pinCode: 117, balance: 17000);
         Customer customer3 = new Customer(name: "Lucky Luke", accountNr: 1234, pinCode: 1234, balance: 344000);
         */
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            bool l = true;
            while (l)
            {
                foreach (var c in customer.CustomerList())
                {
                    if (userInputAccountNumber.Text == c.GetAccountNr().ToString() && userInputPincodeNumber.Password == c.GetPinCode().ToString())
                    {
                        MessageBox.Show("You are logged in " + c.GetName());
                        var inloggad = new Inloggad();
                        inloggad.Show();
                        Close();
                    }
                }
                MessageBox.Show("Wrong accountnumber or password. Please try again!");
                userInputPincodeNumber.Clear();
                userInputAccountNumber.Clear();
                break;
            }
        }
        public void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }

}

