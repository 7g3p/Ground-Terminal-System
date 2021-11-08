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

namespace Ground_Terminal_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            timeBar.Content = DateTime.Now;
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the enter key has been pressed then....???
            if (e.Key == Key.Enter)
            {
                //TextBox temp = (TextBox)sender;

                //timeBar.Content = temp.Text;
            }
        }

        private void realTimeToggle_Click(object sender, RoutedEventArgs e)
        {
            // Variables
            CheckBox rtCheckbox = (CheckBox)sender;

            // Confirms "checked" state; if not checked make realTimeData hidden and reveal dbData table
            if (rtCheckbox.IsChecked == true)
            {
                realTimeData.Visibility = Visibility.Visible;
                // dbData.Visibility = Visibility.Hidden;
            }
            else
            {
                realTimeData.Visibility = Visibility.Hidden;
                // dbData.Visibility = Visibility.Visible;
            }
        }
    }
}
