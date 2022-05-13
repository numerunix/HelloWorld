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

/* Questo codice è sotto licenza MIT */
namespace HelloWorld
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            String s = (System.String)this.FindResource("ciao") as String;
            String s1 = (System.String)this.FindResource("festafinita") as String;
            ciaofrancesca.Text = s +" "+ Nome.Text + " "+ s1;
            Ok.IsEnabled = false;
        }
    }
}
