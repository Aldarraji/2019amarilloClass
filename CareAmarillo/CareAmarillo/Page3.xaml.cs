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
        private Add addProvider;
        public Page3()
        {
            InitializeComponent();
            addProvider = new Add();

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
                addProvider.AddProvider(txtPName.Text, txtAddress.Text, txtZipCode.Text, txtCity.Text, txtState.Text, txtPhone.Text, txtEmail.Text, txtBed.Text);
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
    }
}
