﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        private void Add_Click3(object sender, RoutedEventArgs e)
        {
            About_us about_us = new About_us();
            about_us.Show();
        }
    }

}