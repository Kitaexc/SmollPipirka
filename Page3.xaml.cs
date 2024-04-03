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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        ProductTypesTableAdapter productTypes = new ProductTypesTableAdapter();
        public Page3()
        {
            InitializeComponent();

            ProductTypes.ItemsSource = productTypes.GetData();
            Vibor.DisplayMemberPath = "PrType";
            Vibor.ItemsSource = productTypes.GetData();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ProductTypes.ItemsSource = productTypes.GetDataBy(Poisk.Text);
        }
        private void Vibor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Vibor.SelectedItem != null)
            {
                var id = (int)(Vibor.SelectedItem as DataRowView).Row[0];
                ProductTypes.ItemsSource = productTypes.GetDataBy1(id);
            }
        }
        private void Search2_Click(object sender, RoutedEventArgs e)
        {
            ProductTypes.ItemsSource = productTypes.GetData();
        }
    }
}