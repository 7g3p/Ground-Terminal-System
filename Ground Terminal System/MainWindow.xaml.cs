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
        private List<TelemetryData> teleData;
        private int temp;
        private object thisthingy;

        public MainWindow()
        {
            InitializeComponent();
            timeBar.Content = DateTime.Now;

            // Hide searchBar
            searchBar.Visibility = Visibility.Hidden;
            searchIco.Visibility = Visibility.Hidden;

            teleData = new List<TelemetryData>();
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the enter key has been pressed then....???
            if (e.Key == Key.Enter)
            {
                //teleData.Add(new TelemetryData("test1", DateTime.Now, -1.0, -1.0 - 1.0, -1.0, -1.0, -1.0, -1.0, -1.0));
                //teleData.Add(new TelemetryData("test2", DateTime.Now, -2.0, -2.0 - 2.0, -2.0, -2.0, -2.0, -2.0, -2.0));
                //teleData.Add(new TelemetryData("test3", DateTime.Now, -3.0, -3.0 - 3.0, -3.0, -3.0, -3.0, -3.0, -3.0));
                //teleData.Add(new TelemetryData("test4", DateTime.Now, -4.0, -4.0 - 4.0, -4.0, -4.0, -4.0, -4.0, -4.0));
                //teleData.Add(new TelemetryData("test5", DateTime.Now, -5.0, -5.0 - 5.0, -5.0, -5.0, -5.0, -5.0, -5.0));
                //teleData.Add(new TelemetryData("test6", DateTime.Now, -6.0, -6.0 - 6.0, -6.0, -6.0, -6.0, -6.0, -6.0));
                //teleData.Add(new TelemetryData("test7", DateTime.Now, -7.0, -7.0 - 7.0, -7.0, -7.0, -7.0, -7.0, -7.0));

                //// Update DataGrid with new data list
                //dbDataGrid.ItemsSource = teleData;

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
                dbData.Visibility = Visibility.Hidden;

                // Hide searchBar
                searchBar.Visibility = Visibility.Hidden;
                searchIco.Visibility = Visibility.Hidden;

                // Reveal timeBar
                timeBar.Visibility = Visibility.Visible;
                timeText.Visibility = Visibility.Visible;
            }
            else
            {
                realTimeData.Visibility = Visibility.Hidden;
                dbData.Visibility = Visibility.Visible;

                // Reveal searchBar
                searchBar.Visibility = Visibility.Visible;
                searchIco.Visibility = Visibility.Visible;

                // Hide timeBar
                timeBar.Visibility = Visibility.Hidden;
                timeText.Visibility = Visibility.Hidden;

                // Update DataGrid with new data list
                //dbDataGrid.ItemsSource = teleData;
                tailNum.Text = temp.ToString();
            }
        }

        private void dbDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Variables
            DataGrid dg = (DataGrid)sender;         // Cast sender as DataGrid object
            thisthingy = dg.SelectedItems;          // Save the selected items
        }
    }
}
