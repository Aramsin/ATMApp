using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for Registrering.xaml
    /// </summary>
    public partial class Registrering : Window
    {
        Customer _customer { get; set; }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public Registrering()
        {
            InitializeComponent();
        }
        private void ConfirmRegBtn_Click(object sender, RoutedEventArgs e)
        {
            string nameInput = Name.Text;
            string pinCodeInput = PinCode.Text;
            string accountNrInput = AccountNr.Text;
            string balanceInput = Balance.Text;

            int pinCode = Convert.ToInt32(pinCodeInput);
            int accountNr = Convert.ToInt32(accountNrInput);
            double balance = Convert.ToDouble(balanceInput);

            Customer customer = new Customer();
            customer.CustomerList().Add(new Customer() { name = nameInput, accountNr = accountNr, pinCode = pinCode, balance = balance });

            MessageBox.Show("Du är nu registrerad!");
            var MainWindow = new MainWindow();
            this.Close();
            MainWindow.Show();

        }
    }
}
