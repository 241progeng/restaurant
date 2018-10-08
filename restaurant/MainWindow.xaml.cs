using System.Windows;

//Added for database
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;
//dfwsadasdsa test stesrfdsfvbpdfalds

namespace restaurant
{

    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Clients.Load();
            this.DataContext = db.Clients.Local.ToBindingList();
        }
        // добавление
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ClientsWindow clientWindow = new ClientsWindow(new Client());
            if (clientWindow.ShowDialog() == true)
            {
                Client client = clientWindow.Client;
                db.Clients.Add(client);
                db.SaveChanges();
            }
        }
        // редактирование
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (clientsList.SelectedItem == null) return;
            // получаем выделенный объект
            Client client = clientsList.SelectedItem as Client;

            ClientsWindow clientWindow = new ClientsWindow(new Client
            {
                Id = client.Id,
                Discount = client.Discount,
                Name = client.Name
            });

            if (clientWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                client = db.Clients.Find(clientWindow.Client.Id);
                if (client != null)
                {
                    client.Discount = clientWindow.Client.Discount;
                    client.Name = clientWindow.Client.Name;
                    client.Id = clientWindow.Client.Id;
                    db.Entry(client).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (clientsList.SelectedItem == null) return;
            // получаем выделенный объект
            Client client = clientsList.SelectedItem as Client;
            db.Clients.Remove(client);
            db.SaveChanges();
        }
    }
    public class Client : INotifyPropertyChanged
    {
        private string name;
        private int discount;
        private int id;

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
        public int Discount
        {
            get { return discount; }
            set
            {
                discount = value;
                OnPropertyChanged("Discount");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}
