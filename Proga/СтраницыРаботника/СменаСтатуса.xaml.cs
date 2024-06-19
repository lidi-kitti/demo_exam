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
    /// Логика взаимодействия для СменаСтатуса.xaml
    /// </summary>
    public partial class СменаСтатуса : Page
    {
        private int _status = 0;
        private Заявка _Заявка;
        public СменаСтатуса(Заявка Заявка)
        {
            InitializeComponent();
            _Заявка = Заявка;
            DataContext = _Заявка;
            Статус_cb.ItemsSource = App.Context.Статус.ToList();

        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        { DateTime date = DateTime.Now;
            string date2 = date.ToString();
            _Заявка.Статус_заявки = _status;
            if (_status == 2)
            {
                _Заявка.Дата_завершения = date2;
            }
            else 
            this.NavigationService.Navigate(new ЗаявкиРаботника());
        }
        private void Статус_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Статус defCB = Статус_cb.SelectedItem as Статус;
            _status = defCB.id_статус;

        }
    }
}
