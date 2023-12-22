using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace gamelibrar1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу регистрации
            OpenRegistrationPage();
        }

        private void OpenRegistrationPage()
        {
            // Создаем новый экземпляр окна регистрации
            var registrationWindow = new REG();//RegistrationWindow registrationWindow = new RegistrationWindow();

            // Открываем окно регистрации
            registrationWindow.Show();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на окно входа
            OpenLoginWindow();
        }

        private void OpenLoginWindow()
        {
            // Создаем новый экземпляр окна входа (предположим, у вас есть окно LoginWindow)
            LOG loginWindow = new LOG();

            // Открываем окно входа
            loginWindow.Show();
        }
    }
}