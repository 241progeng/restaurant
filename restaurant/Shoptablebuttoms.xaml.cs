using System.Windows;

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