using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace gamelibrar1
{
    public partial class LOG : Window
    {
        public LOG()
        {
            InitializeComponent();
        }

        private void RemoveTextPassword(object sender, RoutedEventArgs e)
        {
            txtPasswordPlaceholder.Visibility = Visibility.Collapsed;
            txtPassword.Visibility = Visibility.Visible;
            txtPassword.Focus();
        }

       private void loginwindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            // Логика при нажатии кнопки "Далее"
            OpenNewPage();
        }

        private void OpenNewPage()
        {
            // Создание новой страницы или окна и переход к ней
            masterpage newPage = new masterpage();
            newPage.Show();
            this.Close(); // Закрытие текущего окна
        }

        /*private void txtLoginPlaceholder_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLoginPlaceholder.Visibility = Visibility.Collapsed;
            txtLoginPlaceholder.Visibility = Visibility.Visible;
            txtLoginPlaceholder.Focus();
        }*/
    }
}
