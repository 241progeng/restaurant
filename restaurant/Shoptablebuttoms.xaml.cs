using System.Data.Entity;
using System.Windows;
using System.Linq;

// double SUM = db_bill.Bills.Sum(x => x.Price); for final bill list
// TextBlock.Text = SUM.ToString();

namespace restaurant
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Shoptablebuttoms : Window
    {
        BillContext db_bill;
        public Shoptablebuttoms()
        {
            InitializeComponent();
            db_bill = new BillContext();
            db_bill.Bills.Load();
            billGrid.ItemsSource = db_bill.Bills.Local.ToBindingList();
        }
        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            {
                MessageBox.Show("Действие выполнено accept");
                var query = (from d in db_bill.Bills select d).ToList();
                db_bill.Bills.RemoveRange(query);
                db_bill.SaveChanges();
                this.Close();
            }

        }

        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            {
                var query = (from d in db_bill.Bills select d).ToList();
                db_bill.Bills.RemoveRange(query);
                db_bill.SaveChanges();
                this.Close();
            }
        }

    }



}