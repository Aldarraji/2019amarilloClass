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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Window
    {
        SqlConnection connection = new SqlConnection();
        public Page3()
        {
            InitializeComponent();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;user id=db1;Password=db10;";
            connection.Open();

        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            //create account 
            if (txtPName.Text == "" | txtZipCode.Text == "" | txtEmail.Text == "" | txtAddress.Text == "" | txtPhone.Text == "" | txtBed.Text == "" | txtCity.Text == "" | txtState.Text == "")
            {
                MessageBox.Show("Please enter all the required information.");
            }
            else
            {
                //var zipcode = Int32.Parse(txtZipCode.Text);
                AddProvider();
                MessageBox.Show("You have registered successfully. \n Please press ok then log in.");
                this.Hide();
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
            }

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            //display change password and update info 
            this.Hide();
            UpdateInfo update = new UpdateInfo();
            update.Show();
        }

        private void AddProvider()
        {
            using (SqlCommand insertNewProvider = connection.CreateCommand())
            {
                insertNewProvider.CommandText = "insert into Shelter values (@Name, @Address, @ZipCode, @City, @State, @Phone, @Email, @BedVacancy);";
                insertNewProvider.Parameters.Add(new SqlParameter("Name", txtPName.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("Address", txtAddress.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("ZipCode", txtZipCode.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("City", txtCity.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("State", txtState.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("Phone", txtPhone.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("Email", txtEmail.Text));
                insertNewProvider.Parameters.Add(new SqlParameter("BedVacancy", txtBed.Text));
                insertNewProvider.ExecuteNonQuery();
            }
        }
    }
}
