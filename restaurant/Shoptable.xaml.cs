using System.Windows;

//Added for database
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;


namespace restaurant
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Shoptablebuttoms : Window { }
    public partial class Shoptable : Window

    {
        private string name;
        private double price;
        private int counts;

        public int Id { get; set; }

        public Shoptable()
        {   
            InitializeComponent();

        }

        public class Product : INotifyPropertyChanged
        {
            private string name;
            private double price;
            private int counts;

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

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("print");
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
            Product product = productList.SelectedItem as Product;

            if (product.id_p == 1)
                {
                Id = product.id_p;
                price = product.Price;
                name = product.Name;
                counts = product.Counts;
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
}





