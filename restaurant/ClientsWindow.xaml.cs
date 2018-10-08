using System.Windows;

namespace restaurant
{
    public partial class ClientsWindow : Window
    {
        public Client Client { get; private set; }

        public ClientsWindow(Client p)
        {
            InitializeComponent();
            Client = p;
            this.DataContext = Client;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}