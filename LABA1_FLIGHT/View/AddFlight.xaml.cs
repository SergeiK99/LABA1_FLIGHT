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
            cmNum.ItemsSource = FlightModel.Instance.Routes.ToArray();
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if(cmNum.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали номер пути!");
                return;
            }
            if(flNum.Text == "")
            {
                MessageBox.Show("Вы не ввыели номер рейса!");
                return;
            }
            if(ResSeats.Text =="")
            {
                MessageBox.Show("Вы не ввели кол-во забронированных мест");
                return;
            }
            if(PursSeats.Text =="")
            {
                MessageBox.Show("Вы не ввели кол-во купленных мест");
                return;
            }
            if(DateD.SelectedDate == null)
            {
                MessageBox.Show("Вы не выбрали дату отпрпавления");
                return;
            }
            flight.Route = cmNum.SelectedItem as Route;
            flight.FlightNumber = flNum.Text;
            flight.ReservedSeats = Convert.ToInt32(ResSeats.Text);
            flight.PurchasedSeats = Convert.ToInt32(PursSeats.Text);
            flight.DepatureDate = Convert.ToDateTime(DateD.SelectedDate);
            if(Inner.IsChecked == false)
            {
                flight.IsInnerFlight = false;
            }
            else { flight.IsInnerFlight = true; }
            FlightModel.Instance.Flights.Add(flight);
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
