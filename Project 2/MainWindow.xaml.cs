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

/// Week 3		Homework 2
/// File Name: MainWindow.xaml.cs
/// @author: Antonio Monteiro
/// Date:  September 20th 2020

namespace Project_2
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

        private void submitButton_click(object Sender, RoutedEventArgs e)
        {

            //get price from user input
            int price = Int32.Parse(priceTextBox.Text);

            //call function
            calculateChange(price);



        }

        public void calculateChange(int price)
        {

            //declare coin variables
            int quarters, dimes, nickels;

            //calculate quarters required and subtract from price
            quarters = price / 25;
            price = price - quarters * 25;

            //calculate dimes required and subtract from price
            dimes = price / 10;
            price = price - dimes * 10;

            //calculate nickels required and subtract from price
            nickels = price / 5;
            price = price - nickels * 5;

            //change labels to reflectvalues
            quartersLabel.Content = "Quarters: " + quarters;
            dimesLabel.Content = "Dimes: " + dimes;
            nickelsLabel.Content = "Nickels: " + nickels;

        }

    }
}
