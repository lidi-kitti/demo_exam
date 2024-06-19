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
    /// Логика взаимодействия для ВсеЗаявки.xaml
    /// </summary>
    public partial class ВсеЗаявки : Page
    {
        public ВсеЗаявки()
        {
            InitializeComponent();
            GridЗаявкаs.ItemsSource = App.GetContext.Заявка.Where(x => x.ФИО_клиента == App.GlobalId).ToList();
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (GridЗаявкаs.SelectedItem != null)
            {
                var selectedЗаявка = GridЗаявкаs.SelectedItem as Заявка;
                this.NavigationService.Navigate(new РедактированиеОписания(selectedЗаявка));
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Frame());
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void www_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }
            private void Button_Click(object sender, RoutedEventArgs e)
        {
            var removeTask = GridЗаявкаs.SelectedItems.Cast<Заявка>().ToList();
            if (MessageBox.Show($"Выбрана {removeTask.Count()} строка, удалить ", "Attention!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    App.GetContext.Заявка.RemoveRange(removeTask);
                    App.GetContext.SaveChanges();
                    MessageBox.Show("Готово");

                    GridЗаявкаs.ItemsSource = App.GetContext.Заявка.ToList();
                }
                catch
                {

                    MessageBox.Show("Попробуйте ещё раз", "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
