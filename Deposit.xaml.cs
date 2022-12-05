using System.Windows;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for Deposit.xaml
    /// </summary>
    public partial class Deposit : Window
    {
        public Deposit()
        {
            InitializeComponent();
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
