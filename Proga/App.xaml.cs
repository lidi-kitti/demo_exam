﻿using Proga.БД;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Proga
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DataBaseEntities GetContext { get; } = new DataBaseEntities();
        public static DataBaseEntities Context

        { get; } = new DataBaseEntities();

        public static Пользователь CurrentПользователь = null;
        public static string Global { get; set; }
        public static int GlobalId { get; set; }
    }
}
