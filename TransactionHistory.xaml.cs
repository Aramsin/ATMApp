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
        public List<Transaction> TransactionList { get; set; }
        public TransactionHistory()
        {

            InitializeComponent();


            TransactionList = new List<Transaction>();
            Transaction newTransaction = new Transaction(1, 100, true, new DateTime());
            TransactionList.Add(newTransaction);

            DataContext = this;
        }
    }
}
