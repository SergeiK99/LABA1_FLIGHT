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
using LABA1_FLIGHT;

namespace LABA1_FLIGHT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (FlightModel model = new FlightModel())
            {
                //Destination destination = new Destination();
                //destination.CityName = "Moscow";
                //model.Destinations.Add(destination);
                //model.SaveChanges();
                //model.Tickets.ToArray();
            }

        }
    }
}
