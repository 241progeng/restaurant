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

namespace restaurant
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Shoptablebuttoms : Window { }
    public partial class Shoptable : Window

    {
        public Shoptable()
        {
            InitializeComponent();
        }
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("print");
            Shoptablebuttoms shoptablebuttoms  = new Shoptablebuttoms();
            shoptablebuttoms.Show();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар1");
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар2");
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар3");
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар4");
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар5");
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар6");
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар7");
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар8");
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар9");
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар10");
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар11");
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("товар12");
        }
    }
}





