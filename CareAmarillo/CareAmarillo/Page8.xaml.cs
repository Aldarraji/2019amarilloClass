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
        private Update updateUser;
        public Page8()
        {
            InitializeComponent();
            updateUser = new Update();
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            var userid = txtBFNameP2.Text;
            var npassword = txtBFNameP2_Copy.Text;

            //var valaidateLogin = 

            if ( userid == "" || npassword == "")
            {
                MessageBox.Show("Provide all fields!");
            }
            else
            {
                updateUser.UpdateAUser(userid, npassword);
                MessageBox.Show("Password has been successfully changed!");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {


            var userid = txtBFNameP2_Copy1.Text;
            var npassword = txtPW.Text;


            if (userid == "" || npassword == "")
            {
                MessageBox.Show("Provide all fields!");
            }
            else
            {
                updateUser.DeleteAUser(txtBFNameP2_Copy1.Text, txtPW.Text);
            
                MessageBox.Show("User has been deleted successfully!");
            }



        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}