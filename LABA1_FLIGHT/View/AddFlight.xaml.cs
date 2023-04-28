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
using LABA1_FLIGHT.Classes;

namespace LABA1_FLIGHT.View
{
    /// <summary>
    /// Логика взаимодействия для AddFlight.xaml
    /// </summary>
    public partial class AddFlight : Window
    {
        public Flight flight { get; set; }
        public AddFlight()
        {
            InitializeComponent();
            flight = new Flight();
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            flight.ReservedSeats = Convert.ToInt32(ResSeats.Text);
            flight.PurchasedSeats = Convert.ToInt32(PursSeats.Text);
            flight.DepatureDate = Convert.ToDateTime(DateD.SelectedDate);
            FlightModel.Instance.SaveChanges();
            this.DialogResult = true;
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
    }
}
