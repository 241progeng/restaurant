using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;


namespace restaurant
{

    public partial class EnterClient : Window
    {
        ApplicationContext db;

        public string Discount { get; private set; }

        public EnterClient()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Clients.Load();
            this.DataContext = db.Clients.Local.ToBindingList();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // this.DialogResult = true;
            Close();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string em = EmailBox.Text;
            string pw = PasswordBox.Password;

            var clients = (from c in db.Clients where c.Email == em select c).ToList();

            if (clients.Count() == 0)
            {
                MessageBox.Show("Error");

            }
            else
            {
                if (pw == clients.FirstOrDefault<Client>().Password)
                {
                    MessageBox.Show("Discount");
                }
            }

        }
    }

}