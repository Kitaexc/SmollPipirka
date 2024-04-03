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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        ProductsTableAdapter products = new ProductsTableAdapter();
        public Page4()
        {
            InitializeComponent();
            Products.ItemsSource = products.GetData();
            Vibor.DisplayMemberPath = "ID_Product";
            Vibor.ItemsSource = products.GetData();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Products.ItemsSource = products.GetDataBy(Poisk.Text);
        }
        private void Vibor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Vibor.SelectedItem != null)
            {
                var id = (int)(Vibor.SelectedItem as DataRowView).Row[0];
                Products.ItemsSource = products.GetDataBy1(id);
            }
        }
        private void Search2_Click(object sender, RoutedEventArgs e)
        {
            Products.ItemsSource = products.GetData();
        }
    }
}
