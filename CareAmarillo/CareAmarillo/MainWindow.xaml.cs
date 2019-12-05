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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Hide();
            Page2 page2 = new Page2();
            page2.Show();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Hide();
            Page2 page2 = new Page2();
            page2.Show();
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Page2 page2 = new Page2();
            page2.Show();
        }
    }
}
