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
    /// Логика взаимодействия для AddSC.xaml
    /// </summary>
    public partial class AddSC : Window
    {
        public SeatCategory sc { get; set; }
        public AddSC()
        {
            InitializeComponent();
            sc = new SeatCategory();
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            if (tbSC.Text == "")
            {
                MessageBox.Show("Вы оставили поле пустым");
                return;
            }
            sc.Category = tbSC.Text;
            FlightModel.Instance.SeatCategories.Add(sc);
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
