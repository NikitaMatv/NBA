using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Components;
namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NbaBase3Entities DB = new NbaBase3Entities();
        public static Admin LoggedEmployee;
        public static bool IsAutorizate = false;
    }
}
