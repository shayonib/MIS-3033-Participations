using System;
using System.Windows;
using System.Windows.Media;

namespace First_WPF_Application
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


        private void btn1_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            btn1.Background = new SolidColorBrush(Colors.Red);
            MessageBox.Show("This is where the calculated age would go");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int age = DateTime.Today.Year - dtpDate.SelectedDate.Year;
            //I found some examples online and could not figure out how the syntax on how to get the year from the selected date.
            //This is what I used-->  stackoverflow.com/questions/2237587/how-can-i-calculate-age-by-datetimepicker 


        }
    }
}
