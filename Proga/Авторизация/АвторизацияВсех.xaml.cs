
using Proga.МенеджерСтраницы;
using Proga.СтраницыПользователя;
using Proga.СтраницыРаботника;
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

namespace Proga.Авторизация
{
    /// <summary>
    /// Логика взаимодействия для Авторизация.xaml
    /// </summary>
    public partial class АвторизацияВсех : Page
    {
        public АвторизацияВсех()
        {
            InitializeComponent();
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            App.Global = TB_Login.Text;
            var currentПользователь = App.Context.Пользователь.FirstOrDefault(x => x.Логин == TB_Login.Text && x.Пароль == PB_password.Password);
            App.GlobalId = currentПользователь.ID_пользователь;
            
                if (currentПользователь != null)
                {

                    App.CurrentПользователь = currentПользователь;
                    if (App.CurrentПользователь.ID_роль == 1)
                    {
                        NavigationService.Navigate(new МенюПользователь());
                    }

                    else if (App.CurrentПользователь.ID_роль == 2)
                    {
                        NavigationService.Navigate(new МенюМенеджера());
                    }

                    else if (App.CurrentПользователь.ID_роль == 3)
                    {
                        NavigationService.Navigate(new МенюРаботника());
                    }
                }


            else
            {
                MessageBox.Show("Пользователь не найден", "Error");
            }


        }

        private void HL_Reg_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Регистрация());
        }
    }
}
