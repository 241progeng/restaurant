using System.Linq;
using System.Windows;
using System.Data.Entity;
using System.Windows.Controls;
using System.Collections.Generic;

namespace restaurant
{
    public partial class AdminPass : Window
    {
        AdminContext db_a;
        public AdminPass()
        {
            InitializeComponent();

            db_a = new AdminContext();
            db_a.Admins.Load();
            this.DataContext = db_a.Admins.Local.ToBindingList();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string em = EmailBox.Text;
            string pw = PasswordBox.Password;

            var admins = (from c in db_a.Admins where c.E_mail == em select c).ToList();
            if (admins.Count() == 0)
            {
                MessageBox.Show("Error");

            }
            else
            {
                if (pw == admins.FirstOrDefault<Admin>().Password)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
        }
    }

}
