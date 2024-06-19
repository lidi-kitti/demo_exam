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
    /// Логика взаимодействия для РедактированиеОписания.xaml
    /// </summary>
    public partial class РедактированиеОписания : Page
    {
        private Заявка _Заявка;

        public РедактированиеОписания(Заявка Заявка)
        {
            InitializeComponent();
            _Заявка = Заявка;
            DataContext = _Заявка;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _Заявка.Описание_проблемы = Problem_tb.Text;
            MessageBox.Show("Cохранение прошло успешно");
            this.NavigationService.Navigate(new ВсеЗаявки());
        }
    }
}
