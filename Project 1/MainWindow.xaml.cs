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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //declare interest rate
        public const double YEARLY_INTEREST_RATE = .0639;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            //declare textbox variables
            double monthlyPayment = Double.Parse(paymentTextBox.Text);
            double outstandingPayment = Double.Parse(outstandingTextBox.Text);

            //call function
            calculatePayment(monthlyPayment, outstandingPayment);

        }

        static void calculatePayment(double monthlyPayment, double oustandingPayment)
        {

            //calculate monthly rate
            double monthlyInterestRate = (1.0/12.0) * YEARLY_INTEREST_RATE;

            //calculate interest paid
            double interestPaid = oustandingPayment * monthlyInterestRate;

            //calculate principal paid
            double principalPaid = monthlyPayment - interestPaid;

            //output results
            MessageBox.Show("You paid $" + principalPaid + " in principal and $" + interestPaid + " in interest this month.");

        }

    }
}
