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
    /// Interaction logic for TransactionHistory.xaml
    /// </summary>
    public partial class TransactionHistory : Window
    {
        Customer _customer;
        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public List<Transaction> TransactionList { get; set; }
        public TransactionHistory()
        {
            InitializeComponent();

            TransactionList = new List<Transaction>();

            Customer customer = new Customer();
            Transaction newTransaction = new Transaction(1, 100, true, new DateTime(), 999, 888);
            Transaction newTransaction2 = new Transaction(1, 1000, true, new DateTime(), 888, 999);
            TransactionList.Add(newTransaction);
            TransactionList.Add(newTransaction2);

            foreach (Transaction transaction in TransactionList)
            {
                if (transaction.accountReciever == customer.GetAccountNr())
                {
                    allTransactions.ItemsSource = TransactionList;
                }
            }

            
        }
    }
}
