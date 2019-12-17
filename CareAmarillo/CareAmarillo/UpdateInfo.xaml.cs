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
        private Update updateInfo;
        private Search login;
        public UpdateInfo()
        {
            InitializeComponent();
            updateInfo = new Update();
            login = new Search();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userID = txtUserID.Text;
                var password = txtPassword.Text;
                login.FindUser(userID, password);
                MessageBox.Show("Successfully login! \n Please fill out Password, First name, Email then click update. ");
            }
            catch
            {
                MessageBox.Show("Cannot login!");
            }
        }

        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            var userID = txtUserID.Text;
            var password = txtUserPassword.Text;
            var firstName = txtUserFirstName.Text;
            var lastName = txtUserLastName.Text;
            var email = txtUserEmail.Text;
            //var phoneNumber = txtUserPhoneNumber.Text;
            //updateInfo.UpdateAUser(userID, password, firstName, lastName, email);
        }
    }
}
