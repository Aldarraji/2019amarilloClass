using System;
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

using System.Data.SqlClient;
using System.Data.Sql;

namespace CareAmarillo
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
     
    public partial class Page2 : Window
    {
        private Add addAHuman;
        SqlConnection connection = new SqlConnection();

        public Page2()
        {
            InitializeComponent();
            addAHuman = new Add();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void BtnBackP2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void BtnRegP2_Click(object sender, RoutedEventArgs e)
        {
            //create account 


            //take back to the main page to log in
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void BtnRegFoProv_Click(object sender, RoutedEventArgs e)
        {
            //if the textboxes were empty
            if (txtBFNameP2.Text == "" | txtBLNameP2.Text == "" | txtBEmailP2.Text == "" |
                txtBPasswordP2.Text == "" | txtBUserIDP2.Text == "" | txtBPhoneNumeP2.Text == "")
            {
                MessageBox.Show("Plese enter all the required information!!!");
            }

            //create account 


            //show a message box to conferm the regestration
            else
            {
                addAHuman.AddHumanService(txtBFNameP2.Text, txtBLNameP2.Text, txtBEmailP2.Text, txtBUserIDP2.Text, txtBPasswordP2.Text);
                MessageBox.Show("You have registered successfully. \n Please press ok then log in.");
                //take back to the main page to log in
                this.Hide();
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
            }
        }

        private void BtnBackP2_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void BtnChangeP2_Click(object sender, RoutedEventArgs e)
        {
            //display change password and update info 
            this.Hide();
            UpdateInfo update = new UpdateInfo();
            update.Show();
        }

    }
}
