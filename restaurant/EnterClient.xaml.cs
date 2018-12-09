using System.Linq;
using System.Windows;
using System.Data.Entity;
using System.Windows.Controls;
using System.Collections.Generic;

namespace restaurant
{
    public partial class EnterClient : Window
    {
        ApplicationContext db;
        public EnterClient()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Clients.Load();
            this.DataContext = db.Clients.Local.ToBindingList();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string em = EmailBox.Text;
            string pw = PasswordBox.Password;
            dynamic d;

            var clients = (from c in db.Clients where c.Email == em select c).ToList();

            var disc = db.Clients.Find(pw);
            if (clients.Count() == 0)
            {
                MessageBox.Show("Error");

            }
            else
            {
                if (pw == clients.FirstOrDefault<Client>().Password)
                {
                    d = (Sum.sum * disc.Discount) / 100;
                    Sum.sum -= d;
                    Sum.sum.ToString();
                    Close();
                }
            }
        }
    }

}