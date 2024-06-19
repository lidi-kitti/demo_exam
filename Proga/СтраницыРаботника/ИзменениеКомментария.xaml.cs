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
    /// Логика взаимодействия для ИзменениеКомментария.xaml
    /// </summary>
    public partial class ИзменениеКомментария : Page
    {
        private int _comment = 0;
        private Заявка _Заявка;
        public ИзменениеКомментария(Заявка Заявка)
        {
            InitializeComponent();
            _Заявка = Заявка;
            DataContext = _Заявка;
            Комент_cb.ItemsSource = App.Context.Комментарий.ToList();

        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _Заявка.Статус_заявки = _comment;
            MessageBox.Show("Cохранение прошло успешно");
            this.NavigationService.Navigate(new ЗаявкиРаботника());
        }
        private void Комент_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Комментарий defCB = Комент_cb.SelectedItem as Комментарий;
            _comment = defCB.id_комментарий;

        }
    }
}
