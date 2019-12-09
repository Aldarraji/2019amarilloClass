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

namespace CareAmarillo
{
    /// <summary>
    /// Interaction logic for UpdateInfo.xaml
    /// </summary>
    public partial class UpdateInfo : Window
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void BtnRegFoProv_Click(object sender, RoutedEventArgs e)
        {
            //if the loging and other update info was empty, show error message then return
            string i = txtUserIDP9.Text;
            //MessageBox.Show(i.ToString());
            if (i =="")
            {
                lblErrorEditP9.Content = "Please sign in or update info correctly.";
            }
            else if (txtboxPassP9.Text == "")
            {
                lblErrorEditP9.Content = "Please sign in or update info correctly.";
            }

            //page 9 when submit clicked, show user infor to edit. txtBox
            

            

        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnBackP2_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void TxtboxPassP9_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
