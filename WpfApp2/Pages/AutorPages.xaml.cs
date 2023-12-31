﻿using System;
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

namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorPages.xaml
    /// </summary>
    public partial class AutorPages : Page
    {
        public AutorPages()
        {
            InitializeComponent();
        }
        private void AutorBt_Click(object sender, RoutedEventArgs e)
        {
            var employee = App.DB.Admin.FirstOrDefault(emp => emp.Name == LoginTb.Text);
            if (employee == null)
            {
                MessageBox.Show("Логин неверный");
                return;
            }
            if (employee.Passwords != PasswordTb.Password)
            {
                MessageBox.Show("Пароль неверный");
                return;
            }
       
            App.LoggedEmployee = employee;

            if (employee.RoleId == "1")
            {
                NavigationService.Navigate(new MainPages());
            }
            else
            {
                MessageBox.Show("У вас нет доступа к этому приложению");
            }

        }

        
    }
}
