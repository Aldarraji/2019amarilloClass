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

namespace CareAmarillo
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Window
    {

        private Search mysearch;

        public Page4()
        {
            InitializeComponent();
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;user id=db1;Password=db10;";
            //connection.Open();
            mysearch = new Search();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();

            InitializeComponent();

        }

        private void txtNameToSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // string s = txtNameToSearch.Text;
            var userInput = txtNameToSearch.Text;
            var databaseinfo = mysearch.FindAShelter(userInput);
            lblResult.Content = databaseinfo;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
