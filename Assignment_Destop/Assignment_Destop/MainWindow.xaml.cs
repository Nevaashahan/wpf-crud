
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Assignment_Destop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            DataContext = new CollectionWindow();
            InitializeComponent();
 
        }




        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            // Minimize the window
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            // Maximize or restore the window
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }






        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Listview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ShutDown_Click(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

    }
}
