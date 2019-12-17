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
                var valaidateLogin = login.FindUser(userID, password);


                if (valaidateLogin == 1 || valaidateLogin == 2 || valaidateLogin == 3 || valaidateLogin == 4 || valaidateLogin == 5)
                {
                    MessageBox.Show("Successfully login! \n Please fill out Password, First name, Email then click update. ");
                }
                else
                {
                    MessageBox.Show("Cannot login, Wrong infomation!");
                }
            }
            catch
            {
                MessageBox.Show("Connection time out, something went wront!");
            }
        }

        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            var userID = txtUserID.Text;
            var password = txtUserPassword.Text;
            var firstName = txtUserFirstName.Text;
            var lastName = txtUserLastName.Text;
            var email = txtUserEmail.Text;

            if (userID == "" || password == "" || firstName == "" || lastName == "" || email == "")
            {
                MessageBox.Show("Please provide all field!");
            }
            else
            {
                updateInfo.UpdateAUser(userID, password, firstName, lastName, email);
            }
        }
    }
}
