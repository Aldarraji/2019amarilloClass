﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace CareAmarillo
{
    /// <summary>
    /// Interaction logic for Page8.xaml
    /// </summary>
    public partial class Page8 : Window
    {
        public Page8()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();

            InitializeComponent();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            //MainWindow MainWindow = new MainWindow();
            //MainWindow.Show();
        }

    }
}
