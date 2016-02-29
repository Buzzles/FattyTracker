using FattyTracker;
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

namespace FattyTrackerUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            ////greetingOutput.Text = "Hello, " + nameInput.Text + "!";
        }

        private void SaveWeight_Click(object sender, RoutedEventArgs e)
        {
            var newWeight = new WeightDetails();

            ////var newWeight2 = sender.DataContext as Weight;

            var item = (WeightDetails)(sender as FrameworkElement).DataContext;

            ////var weightDetails = new WeightDetails
            ////{
            ////    Weight = item,
            ////    Date = new DateTime()
            ////};
        }
    }
}
