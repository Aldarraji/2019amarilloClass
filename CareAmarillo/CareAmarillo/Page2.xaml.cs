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
        SqlConnection connection = new SqlConnection();

        public Page2()
        {
            InitializeComponent();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;user id=db1;Password=db10;";
            connection.Open();
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
                AddHumanService();
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

        private void AddHumanService()
        {
            using (SqlCommand insertNewProvider = connection.CreateCommand())       //write a function for that
            {
                insertNewProvider.CommandText = "insert into Person values (@ID, @FirstName, @LastName, @Email, @TypeID, @UserID, @ShelterID, @Password);";
                insertNewProvider.Parameters.Add(new SqlParameter("FirstName", txtBFNameP2.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("LastName", txtBLNameP2.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("Email", txtBEmailP2.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("TypeID", 6));
                insertNewProvider.Parameters.Add(new SqlParameter("UserID", txtBUserIDP2.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("ShelterID", null));
                insertNewProvider.Parameters.Add(new SqlParameter("Password", txtBPasswordP2.Text));
                insertNewProvider.ExecuteNonQuery();
            }
        }
    }
}
