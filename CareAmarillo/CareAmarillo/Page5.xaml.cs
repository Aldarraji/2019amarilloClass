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
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Window
    {
        private Search shelterSearch;
        public Page5()
        {
            InitializeComponent();
            shelterSearch = new Search();
        }

        private void txtSearchpg5_Click(object sender, TextChangedEventArgs e)
        {
            var userinput = shelterSearch.FindAShelter(txtSearchpg5.Text);

            if (userinput == "Search for Human Service Providers..")
            {
                MessageBox.Show("Type in values to search!");
            }
            else
            {


                // pass it into list box
                lstResultsPG5.Items.Add(userinput);
            }

        }

        private void btnSearchPG5_Click(object sender, RoutedEventArgs e)
        {
            var userinput = shelterSearch.FindAShelter(txtSearchpg5.Text);

            if (userinput == "Search for Human Service Providers..")
            {
                MessageBox.Show("Type in values to search!");
            }
            else
            {


                // pass it into list box
                lstResultsPG5.Items.Add(userinput);
            }

        }

        private void txtSearchpg5_MouseEnter(object sender, TextChangedEventArgs e)
        {
            if (txtSearchpg5.Text == "Search for Human Service Providers..")
            {
                txtSearchpg5.Text = "";
                txtSearchpg5.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            }
        }

        private void txtSearchpg5_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtSearchpg5.Text == "")
            {
                txtSearchpg5.Text = "Search for Human Service Providers..";
                txtSearchpg5.Foreground = new SolidColorBrush(Color.FromRgb(112, 128, 144));

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if (txtSearchpg5.Text == "Search available resources..")
            {
                MessageBox.Show("There is nothing to be cleared!");

            }
            else
            {
                lstResultsPG5.Items.Clear();
                txtSearchpg5.Text = "Search for Human Service Providers..";
                txtSearchpg5.Foreground = new SolidColorBrush(Color.FromRgb(112, 128, 144));
            }

          

        }

        private void txtSearchpg5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
