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

namespace WpfApp1
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
        private bool checknumber()
        {
            double check_income = txt_income.Text.Length, check_expenditure = txt_expenditure.Text.Length,
                checkcost = txt_cost.Text.Length;
            if (check_income == 0)
            {
                txt_income.Focus();
                txt_error_show.Content = ("enter number");
                return false;
            }
            else if (check_expenditure == 0)
            {
                txt_expenditure.Focus();
                txt_error_show.Content = ("enter  number");
                return false;
            }
            else if (checkcost == 0)
            {
                txt_cost.Focus();
                txt_error_show.Content = ("enter information");
                return false;
            }

            return true;
        }

        private void calculate1_Click(object sender, RoutedEventArgs e)
        {
            if (checknumber() == true)
            {

                think();
            }


        }

        private void think()
        {
            double pocket = double.Parse(txt_income.Text) - (double.Parse(txt_expenditure.Text));
            double total_day = (double.Parse(txt_cost.Text)) / pocket;
            txt_day.Content = total_day.ToString();

            if (total_day < 0)
            {
                txt_error_show.Content = ("you can't buy the Item");
                txt_day.Content = ("error");
            }


        }

        private void txt_income_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_income.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only number");
                txt_income.Text = txt_income.Text.Remove(txt_income.Text.Length - 1);
            }
        }

        private void txt_expenditure_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_expenditure.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only number");
                txt_expenditure.Text = txt_expenditure.Text.Remove(txt_expenditure.Text.Length - 1);
            }
        }

        private void txt_cost_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_cost.Text, "[^0-9]"))
            {
                MessageBox.Show("please enter only number");
                txt_cost.Text = txt_cost.Text.Remove(txt_cost.Text.Length - 1);
            }


        }




    }
}
