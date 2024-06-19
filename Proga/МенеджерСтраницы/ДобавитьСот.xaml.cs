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
    /// Логика взаимодействия для ДобавитьСот.xaml
    /// </summary>
    public partial class ДобавитьСот : Page
    {
        public ДобавитьСот()
        {
            InitializeComponent();
            GridEmp.ItemsSource = App.GetContext.Пользователь.ToList().Where(x => x.ID_роль == 3);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Frame());
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
             //this.NavigationService.Navigate(new НовыйСотрудник());
        }
    }
}
