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

namespace restaurant
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Shoptablebuttoms : Window
    {
        public Shoptablebuttoms()
        {
            InitializeComponent();
        }
        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            {
                MessageBox.Show("Действие выполнено accept");
                this.Close();
            }

        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            {
                this.Close(); // закрытие окна
            }
        }

    }



}