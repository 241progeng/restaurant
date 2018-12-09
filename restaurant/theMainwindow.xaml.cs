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

namespace restaurant
{
    public partial class theMainWindow : Window
    {
        public theMainWindow()
        {
            InitializeComponent();

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Shoptable taskWindow = new Shoptable();
            taskWindow.Show();
        }
        private void Add_Click2(object sender, RoutedEventArgs e)
        {
            AdminPass AdminPass = new AdminPass();
            AdminPass.Show();
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
        }
        private void Add_Click3(object sender, RoutedEventArgs e)
        {
            About_us about_us = new About_us();
            about_us.Show();
        }
    }
    public class Admin : INotifyPropertyChanged
    {
        private string e_mail;
        private string password;
        private int idd;
        public int Idd { get; set; }

        public string E_mail
        {
            get { return e_mail; }
            set
            {
                e_mail = value;
                OnPropertyChanged("E_mail");
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
    public class AdminContext : DbContext
    {
        public AdminContext() : base("DefaultConnection")
        {
        }
        public DbSet<Admin> Admins { get; set; }
    }
}