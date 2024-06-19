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

namespace Proga.СтраницыПользователя
{
    /// <summary>
    /// Логика взаимодействия для НоваяЗаявка.xaml
    /// </summary>
    public partial class НоваяЗаявка : Page
    {
        private Заявка _currentЗаявка = new Заявка();
        private int _оборудование = 0;
        public НоваяЗаявка()
        {
            InitializeComponent();

            DataContext = _currentЗаявка;

            Оборудование_cb.ItemsSource = App.Context.Оборудование.ToList();
          
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Frame());
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime data1 = DateTime.Now;
            string data = data1.ToString();
            var currentПользователь = App.Context.Пользователь.FirstOrDefault(x => x.Логин == App.Global);
            try
            {
                var заявка = new Заявка
                {
                    Дата_добавления = data,
                    Вид_оборудования = _оборудование,
                    Модель = Моделька.Text,
                    Описание_проблемы = Problem_tb.Text,
                    ФИО_клиента = App.GlobalId,
                    Телефон_клиента = currentПользователь.Телефон,
                    Статус_заявки = 3,
                    
                };
                App.GetContext.Заявка.Add(заявка);
                App.GetContext.SaveChanges();
                MessageBox.Show("Заявка saved", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                this.NavigationService.Navigate(new Frame());

            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }



        }

        private void Оборудование_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Оборудование defCB = Оборудование_cb.SelectedItem as Оборудование;
            _оборудование = defCB.id_оборудование;

        }
    }
}
