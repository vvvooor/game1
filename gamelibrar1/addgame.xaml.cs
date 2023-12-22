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
    /// Логика взаимодействия для addgame.xaml
    /// </summary>
    public partial class addgame : Window
    {
        public addgame()
        {
            InitializeComponent();
        }

        private void GoToLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика при нажатии кнопки "Перейти в библиотеку"
            OpenLibraryPage();
        }

        private void OpenLibraryPage()
        {
            // Открываем страницу библиотеки
            library libraryPage = new library();
            libraryPage.Show();
            this.Close();
        }

        private void TitleTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            // Логика при изменении текста в поле "Название игры"
            // Добавьте здесь логику обработки изменения названия игры
        }
        public class Game
        {
            public string Title { get; set; }
            public string Genre { get; set; }
            public string Platform { get; set; }
            public int Year { get; set; }

            public Game(string title, string genre, string platform, int year)
            {
                Title = title;
                Genre = genre;
                Platform = platform;
                Year = year;
            }
        }
        public class Library
        {
            private static List<Game> games = new List<Game>();

            public static void AddGame(Game game)
            {
                games.Add(game);
            }

            // Другие методы и свойства библиотеки, если необходимо
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получение данных из TextBox
            string title = TitleTextBox.Text;
            string genre = GenreTextBox.Text;
            string platform = PlatformTextBox.Text;
            int year;

            // Обработка года выпуска
            if (int.TryParse(YearTextBox.Text, out year))
            {
                // Создание экземпляра игры или использование вашей логики
                Game newGame = new Game(title, genre, platform, year);

                // Добавление игры в библиотеку (замените на вашу логику)
                Library.AddGame(newGame);

                // Очистка полей TextBox
                TitleTextBox.Text = "Название игры";
                GenreTextBox.Text = "Жанр";
                PlatformTextBox.Text = "Платформа";
                YearTextBox.Text = "Год выпуска";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный год выпуска.");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
