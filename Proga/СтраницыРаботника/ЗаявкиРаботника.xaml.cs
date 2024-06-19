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

namespace Proga.СтраницыРаботника
{
    /// <summary>
    /// Логика взаимодействия для ЗаявкиРаботника.xaml
    /// </summary>
    public partial class ЗаявкиРаботника : Page
    {
        public ЗаявкиРаботника()
        {
            InitializeComponent();
            GridЗаявкаs.ItemsSource = App.Context.Заявка.Where(x=>x.ФИО_мастера==App.GlobalId).ToList();
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (GridЗаявкаs.SelectedItem != null)
            {
                var selectedЗаявка = GridЗаявкаs.SelectedItem as Заявка;
                this.NavigationService.Navigate(new СменаСтатуса(selectedЗаявка));
            }
        }
        private void Коммент_Click(object sender, RoutedEventArgs e)
        {
            if (GridЗаявкаs.SelectedItem != null)
            {
                var selectedЗаявка = GridЗаявкаs.SelectedItem as Заявка;
                this.NavigationService.Navigate(new ИзменениеКомментария(selectedЗаявка));
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Frame());
        }
    }
}
