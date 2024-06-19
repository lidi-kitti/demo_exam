using Proga.БД;
using Proga.СтраницыПользователя;
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


namespace Proga.Авторизация
{
    /// <summary>
    /// Логика взаимодействия для Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Page
    {
        private Пользователь _currentЗаявка = new Пользователь();
        public Регистрация()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var пользователь = new Пользователь
                {
                    ФИО = Surname_tb.Text,
                    Телефон = Email_tb.Text,
                    Логин = Login_tb.Text,
                    Пароль = Password_pb.Password,
                    ID_роль = 1,

                };
                App.GetContext.Пользователь.Add(пользователь);
                App.GetContext.SaveChanges();
                MessageBox.Show("Пользователь сохранён", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                App.Global = Surname_tb.Text;
                this.NavigationService.Navigate(new Frame());

            }
            catch
            {
                MessageBox.Show("Пользователь не найден", "Error");
            }

            this.NavigationService.Navigate(new МенюПользователь());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
