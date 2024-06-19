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
    /// Логика взаимодействия для СтатистикаКомпании.xaml
    /// </summary>
    public partial class СтатистикаКомпании : Page
    {
        public СтатистикаКомпании()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            int redy = App.Context.Заявка.Where(x => x.Статус_заявки == 2).Count();
            кол_заявк.Content = redy;

            var completedOrders = App.Context.Заявка.Where(x => x.Статус_заявки == 2).ToList();
            int col = completedOrders.Count();

            if (completedOrders.Count > 0)
            {
                TimeSpan totalDuration = TimeSpan.Zero;
                foreach (var order in completedOrders)
                {
                    DateTime startDate = DateTime.Parse(order.Дата_добавления);
                    DateTime endDate = DateTime.Parse(order.Дата_завершения);
                    TimeSpan duration = endDate - startDate;
                    totalDuration += duration;
                }
                TimeSpan averageDuration = TimeSpan.FromTicks(totalDuration.Ticks / col);
                Ср_заявк.Content = averageDuration.ToString();
            }
            else
            {
                Ср_заявк.Content = "Нет выполненных заявок";
            }


        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Frame());
        }
    }
}
