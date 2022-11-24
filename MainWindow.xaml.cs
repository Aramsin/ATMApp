using System.Windows;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (userInputAccountNumber.Text != "1234" || userInputPincodeNumber.Password != "9999")
            {
                MessageBox.Show("Wrong details. Please try again");
            }
            else
            {
                MessageBox.Show("You are logged in!");
            }
        }
    }
}
