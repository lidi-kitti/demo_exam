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
    /// Логика взаимодействия для МенюПользователь.xaml
    /// </summary>
    public partial class МенюПользователь : Page
    {
        public МенюПользователь()
        {
            InitializeComponent();
        }

        private void AddNewЗаявка_Btn_Click(object sender, RoutedEventArgs e)
        {
            FrameMainMenu.Content = new НоваяЗаявка();
        }

        private void AllЗаявкаs_Btn_Click(object sender, RoutedEventArgs e)
        {
            FrameMainMenu.Content = new ВсеЗаявки();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var currentПользователь = App.Context.Пользователь.FirstOrDefault(x => x.Логин == App.Global);
            App.GlobalId = currentПользователь.ID_пользователь;
        }
    }
}
