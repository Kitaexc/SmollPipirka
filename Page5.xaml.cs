using SmollPipirka.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SmollPipirka
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();
        public Page5()
        {
            InitializeComponent();

            Orders.ItemsSource = orders.GetData();
            Vibor.DisplayMemberPath = "ID_Product";
            Vibor.ItemsSource = orders.GetData();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Orders.ItemsSource = orders.GetDataBy(Poisk.Text);
        }
        private void Vibor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Vibor.SelectedItem != null)
            {
                var id = (int)(Vibor.SelectedItem as DataRowView).Row[0];
                Orders.ItemsSource = orders.GetDataBy1(id);
            }
        }
        private void Search2_Click(object sender, RoutedEventArgs e)
        {
            Orders.ItemsSource = orders.GetData();
        }
    }
}

