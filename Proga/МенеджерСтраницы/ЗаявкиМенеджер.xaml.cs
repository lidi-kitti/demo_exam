using Proga.БД;
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

namespace Proga.МенеджерСтраницы
{
    /// <summary>
    /// Логика взаимодействия для ЗаявкиМенеджер.xaml
    /// </summary>
    public partial class ЗаявкиМенеджер : Page
    {
        public ЗаявкиМенеджер()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                App.GetContext.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridЗаявкаs.ItemsSource = App.GetContext.Заявка.ToList();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Frame());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (GridЗаявкаs.SelectedItem != null)
            {
                var selectedЗаявка = GridЗаявкаs.SelectedItem as Заявка;
                this.NavigationService.Navigate(new ИзменитьМастера(selectedЗаявка));
            }
        }
        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterGridBySearch();
        }
        private void FilterGridBySearch()
        {
            var searchText = Poisk.Text.ToLower();
            var filteredData = App.GetContext.Заявка.Where(z => z.id_заявка.ToString().Contains(searchText)).ToList();
            GridЗаявкаs.ItemsSource = filteredData;
        }
    }
}
