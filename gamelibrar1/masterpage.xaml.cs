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
using System.Windows.Shapes;

namespace gamelibrar1
{
    /// <summary>
    /// Логика взаимодействия для masterpage.xaml
    /// </summary>
    public partial class masterpage : Window
    {
        public masterpage()
        {
            InitializeComponent();
            Loaded += mainpapage_Loaded;

            /* AddGamesButton.Click += AddGamesButton_Click;
             LibraryButton.Click += LibraryButton_Click;
             ProfileButton.Click += ProfileButton_Click;
            */
        }
        private void mainpapage_Loaded(object sender, RoutedEventArgs e)
        {
            // Логика при загрузке окна
        }


        private void AddGamesButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика при нажатии кнопки "Добавление игр"
            OpenNewWindow(new addgame());
        }

        private void LibraryButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика при нажатии кнопки "Библиотека"
            OpenNewWindow(new library());
        }
        /* private void ProfileButton_Click(object sender, RoutedEventArgs e)
         {
             // Логика при нажатии кнопки "Профиль"
             OpenNewWindow(new prof());
         }*/

        private void OpenNewWindow(Window window)
        {
            // Открываем новое окно
            window.Show();
        }

        private void SearchTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            // Логика при изменении текста в поле поиска
            // Добавьте здесь логику поиска или фильтрации
        }


    }
}