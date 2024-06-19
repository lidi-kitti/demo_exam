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
    /// Логика взаимодействия для ИзменитьМастера.xaml
    /// </summary>
    public partial class ИзменитьМастера : Page
    {
        private int _master = 0;
        private Заявка _Заявка;

        public ИзменитьМастера(Заявка Заявка)
        {
            InitializeComponent();
            _Заявка = Заявка;
            DataContext = _Заявка;
            Пользователь_cb.ItemsSource = App.Context.Пользователь.Where(x=>x.ID_роль==3).ToList();

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _Заявка.ФИО_мастера = _master;
            MessageBox.Show("Сохранение прошло успешно", "Ok");
            this.NavigationService.Navigate(new ЗаявкиМенеджер());
        }
        private void Пользователь_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Пользователь defCB = Пользователь_cb.SelectedItem as Пользователь;
            _master = defCB.ID_пользователь;
           
        }
    }
}

