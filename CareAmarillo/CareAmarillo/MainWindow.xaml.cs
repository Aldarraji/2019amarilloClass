using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object NavigationService { get; private set; }
        public object NavigationFrame { get; private set; }

        public MainWindow()
        {
            InitializeComponent();


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project1;user id=db1;Password=db10;";
            try
            {
                connection.Open();
                //MessageBox.Show(connection.ServerVersion + "Successfully@!sdfsfd");
            }
            catch
            {
                MessageBox.Show("error");
                this.Hide();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Hide();
            Page2 page2 = new Page2();
            page2.Show();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Page2 page2 = new Page2();
            page2.Show();
        }

        private void BtnRegFoHS_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Page2 page2 = new Page2();
            page2.Show();
        }

        private void BtnRegFoProv_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Page3 page3 = new Page3();
            page3.Show();
        }

        private void BtnChangeP2_Click(object sender, RoutedEventArgs e)
        {
            //display change password and update info 
            this.Hide();
            UpdateInfo update = new UpdateInfo();
            update.Show();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            //if user did not supply userID pr password
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please enter a valid UserID.");
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a valid password.");
            }

            //if the userID and password did not match what we have in database


            //else direct them to the correct User Page
        }
    }
}
