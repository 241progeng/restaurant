using System.Windows;
//Added for database
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

//using System.Net.Mail;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;
//using System.Net;

namespace restaurant
{
    //class Message
    //{
    //    static void message(string[] args)
    //    {
    //        MailAddress fromMailAddress = new MailAddress("usualworker@gmail.com", "Работяга обычный");
    //        MailAddress toAddress = new MailAddress("kirill.sing2000@gmail.com","Kirill Sing");

    //        using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress ))
    //        using (SmtpClient smtpClient = new SmtpClient())
    //        {
    //            mailMessage.Subject = "My Subject";
    //            mailMessage.Body = "Text in the body";

    //            smtpClient.Host = "smtp.gmail.com";
    //            smtpClient.Port = 587;
    //            smtpClient.EnableSsl = true;
    //            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
    //            smtpClient.UseDefaultCredentials = false;
    //            smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "q1w2e3r4zqxwecvr");

    //            smtpClient.Send(mailMessage);
    //        }
    //    }
    //}
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
            if (ClientsList.SelectedItem == null) return;
            // получаем выделенный объект
            Client client = ClientsList.SelectedItem as Client;

            ClientsWindow clientWindow = new ClientsWindow(new Client
            {
                Id = client.Id,
                Discount = client.Discount,
                Name = client.Name,
                Email=client.Email,
                Password=client.Password
            });

            if (clientWindow.ShowDialog() == true)
            {
                // получаем измененный объект
                client = db.Clients.Find(clientWindow.Client.Id);
                if (client != null)
                {
                    client.Email = clientWindow.Client.Email;
                    client.Discount = clientWindow.Client.Discount;
                    client.Name = clientWindow.Client.Name;
                    client.Id = clientWindow.Client.Id;
                    client.Password = clientWindow.Client.Password;
                    db.Entry(client).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
        // удаление
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (ClientsList.SelectedItem == null) return;
            // получаем выделенный объект
            Client client = ClientsList.SelectedItem as Client;
            db.Clients.Remove(client);
            db.SaveChanges();
        }
    }
    public class Client : INotifyPropertyChanged
    {
        private string name;
        private int discount;
        private int id;
        private string email;
        private string password;

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
        [Key]
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("E-mail");
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
