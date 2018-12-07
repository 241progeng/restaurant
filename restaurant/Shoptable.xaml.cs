using System.Windows;

//Added for database
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Data;
using System.Windows.Controls;

//        double SUM = db_bill.Bills.Sum(x => x.Price); for final bill list

namespace restaurant
{
    //public class Calculator : INotifyPropertyChanged
    //{
    //    private dynamic summ;
    //    public dynamic Summ
    //    {
    //        get { return summ; }
    //        set
    //        {
    //            summ = value;
    //            OnPropertyChanged("Summ");
    //        }
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged([CallerMemberName]string prop = "")
    //    {
    //        if (PropertyChanged != null)
    //            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    //    }
    //}
    public static class Sum
    {
        public static double sum;
    }
    public partial class Shoptablebuttoms : Window { }
    public partial class Shoptable : Window
    {
        ProductContext db_prod;
        BillContext db_bill;
        public Bill Bill { get; private set; }
        //public Calculator Calculator { get; private set; }
        public Shoptable()
        {   
            InitializeComponent();

            db_prod = new ProductContext();
            db_prod.Products.Load();
            db_bill = new BillContext();
            db_bill.Bills.Load();
            this.DataContext = db_bill.Bills.Local.ToBindingList();
            //TextBlock.Text = Calculator.Summ;
            TextBlock.Text = Sum.sum.ToString();
        }
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            Shoptablebuttoms shoptablebuttoms  = new Shoptablebuttoms();
            shoptablebuttoms.Show();
            Sum.sum = 0;
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            EnterClient enterClient = new EnterClient();
            enterClient.Show();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string name="Black_Tea";
            int ID = 1;
               
            var c = db_prod.Products.Find(ID);
            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count=1};
                db_bill.Bills.Add(bill);
                //Calculator.Summ += c.Price;
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.SaveChanges();
            }
            else
            {         MessageBox.Show("This product is absent");          }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            string name = "Green_Tea";
            int ID = 2;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            string name = "Espresso";
            int ID = 3;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            string name = "Latte";
            int ID = 4;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            string name = "Donut";
            int ID = 5;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            string name = "Croissant";
            int ID = 6;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            string name = "Swissroll";
            int ID = 7;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            string name = "Apple_Pie";
            int ID = 8;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            string name = "Cheesecake";
            int ID = 9;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            string name = "Brownie";
            int ID = 10;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            string name = "Cupcake";
            int ID = 11;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
            string name = "Pancake";
            int ID = 12;

            var c = db_prod.Products.Find(ID);

            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                Bill bill = new Bill { Name = c.Name, Price = c.Price, Count = 1 };
                Sum.sum += c.Price;
                TextBlock.Text = Sum.sum.ToString();
                db_bill.Bills.Add(bill);
                db_bill.SaveChanges();
            }
            else
            {
                MessageBox.Show("This product is absent");
            }
        }
    }
    public class Product : INotifyPropertyChanged
    {
        private string name;
        private double price;
        private int counts;

        [Key]
        public int id_p { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public int Counts
        {
            get { return counts; }
            set
            {
                counts = value;
                OnPropertyChanged("Counts");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class Bill : INotifyPropertyChanged
    {
        private string name;
        private double price;
        private int count;

        [Key]
        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class BillContext : DbContext
    {
        public BillContext() : base("DefaultConnection")
        {
        }
        public DbSet<Bill> Bills { get; set; }
    }
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DefaultConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
    }

}