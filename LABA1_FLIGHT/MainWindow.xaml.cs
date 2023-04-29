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
using LABA1_FLIGHT.Classes;
using LABA1_FLIGHT.View;

namespace LABA1_FLIGHT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FlightModel db = FlightModel.Instance;
        public Ticket ticket { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            cbDest.ItemsSource = db.Flights.ToArray();
            cbCategory.ItemsSource = db.SeatCategories.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //using (FlightModel model = new FlightModel())
            //{
                // Добавление
                //Destination destination = new Destination();
                //destination.CityName = "Moscow";
                //model.Destinations.Add(destination);
                //model.SaveChanges();
                //model.Tickets.ToArray();

                // Получение данных
                /*var destList = model.Destinations.ToList();
                foreach(var dest in destList)
                {
                    cbDest.Items.Add(dest.CityName);
                }
                var categotyList = model.SeatCategories.ToList();
                foreach (var category in categotyList)
                {
                    cbCategory.Items.Add(category.Category);
                }*/
            //}

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (cbDest.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали пункт назначения!");
                return;
            }
            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали категорию места!");
                return;
            }
            if(Reserved.IsChecked == true)
            {
                ticket.IsReserved = true;
            }
            else { ticket.IsReserved = false; }
            ticket.SeatCategory = cbCategory.SelectedItem as SeatCategory;
            ticket.Flight = cbDest.SelectedItem as Flight;
            db.Tickets.Add(ticket);
            db.SaveChanges();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) // Добавление категорий мест
        {
            AddSC form = new AddSC();
            form.ShowDialog();
            cbCategory.ItemsSource = db.SeatCategories.ToList();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) // Добавление рейсов
        {
            AddFlight form = new AddFlight();
            form.ShowDialog();
            cbDest.ItemsSource = db.Flights.ToArray();
        }

        private void bt2_Click(object sender, RoutedEventArgs e) //Вывод Tickets в dgTickets
        {

        }
    }
}
