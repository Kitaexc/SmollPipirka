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
using SmollPipirka.DataSet1TableAdapters;

namespace SmollPipirka
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        ClientTagsTableAdapter clientTags = new ClientTagsTableAdapter();
        public Page1()
        {
            InitializeComponent(); 
            ClientTags.ItemsSource = clientTags.GetData();
            Vibor.DisplayMemberPath = "TagName"; 
            Vibor.ItemsSource = clientTags.GetData();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ClientTags.ItemsSource = clientTags.GetDataBy(Poisk.Text);
        }
        private void Vibor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Vibor.SelectedItem != null)
            {
                var id = (int)(Vibor.SelectedItem as DataRowView).Row[0];
                ClientTags.ItemsSource = clientTags.GetDataBy1(id);
            }
        }
        private void Search2_Click(object sender, RoutedEventArgs e)
        {
            ClientTags.ItemsSource = clientTags.GetData();
        }
    }


}

