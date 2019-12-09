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
using System.Windows.Shapes;

namespace CareAmarillo
{
    /// <summary>
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Window
    {
        public Page6()
        {
            InitializeComponent();
            txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(112, 128, 144));
        }

        private void LblUsername_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("If user click on this, another page will open to update user information. Password, Name, Email, etc.!");
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            var searchInput = txtSearch.Text;
            lstResult.Items.Add(searchInput);

        }

        private void TxtSearch_MouseEnter(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Search available resources..")
            {
                txtSearch.Text = "";
                txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            }
        }

        private void TxtSearch_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search available resources..";
                txtSearch.Foreground = new SolidColorBrush(Color.FromRgb(112, 128, 144));

            }
        }
    }
}
