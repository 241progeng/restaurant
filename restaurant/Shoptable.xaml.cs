using System.Windows;

//Added for database
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

using System.Diagnostics;

using System.Linq;
using System.Data.SQLite;
using System;
using System.Windows.Data;

namespace restaurant
{    public partial class Shoptablebuttoms : Window { }
    public partial class Shoptable : Window
    {
        ProductContext db_prod;
        public Shoptable()
        {   
            InitializeComponent();

            db_prod = new ProductContext();
            db_prod.Products.Load();

        }
        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            Shoptablebuttoms shoptablebuttoms  = new Shoptablebuttoms();
            shoptablebuttoms.Show();
        }
        private void Button_Click13(object sender, RoutedEventArgs e)
        {
            EnterClient enterClient = new EnterClient();
            enterClient.Show();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            string name="Black_Tea";
            //int products = (from pr in db_prod.Products where pr.Name == name select pr).Count();

            //if (products > 0)
            //{
            //    List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
            //    foreach (var l in list)
            //    {
            //        l.Counts--;
            //    }

            //уменьшение кол-ва на 1 в базе

            //Debug.WriteLine(list.Count());
            //int c = (from cnt in db_prod.Products where cnt.Name == name select cnt.Counts);


            int ID = 1;
                     
            var c = db_prod.Products.Find(ID);


            Debug.WriteLine(c.Counts);
            if (c.Counts > 0)
            {
                List<Product> list = (from pr in db_prod.Products where pr.Name == name select pr).ToList();
                c.Counts--;
                // DataContext = list;
                // db_prod.SaveChanges();
                Debug.WriteLine(c.Counts);
            }
            else
            {
                    MessageBox.Show("This product is absent");
            }

        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        { 
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
        }
        private void Button_Click12(object sender, RoutedEventArgs e)
        {
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
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DefaultConnection")
        {
        }
        public DbSet<Product> Products { get; set; }
    }

}





