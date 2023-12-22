using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для library.xaml
    /// </summary>
    public partial class library : Window
    {
        public ObservableCollection<Game> Games { get; set; }

        public library()
        {
            InitializeComponent();
            Games = new ObservableCollection<Game>();
            InitializeComboBoxes();
            InitializeGamesListView();
        }
        private void InitializeComboBoxes()
        {
            // Заполнение комбо-боксов данными (замените на свою логику)
            //GenreComboBox.Items.Add("Action");
            //GenreComboBox.Items.Add("Adventure");
            //PlatformComboBox.Items.Add("PC");
            //PlatformComboBox.Items.Add("Xbox");
            //PlatformComboBox.Items.Add("PlayStation");
        }

        private void InitializeGamesListView()
        {
            // Заполнение списка игр данными (замените на свою логику)
            Games.Add(new Game { Title = "Game 1", Genre = "Action", Platform = "PC", Year = 2022 });
            Games.Add(new Game { Title = "Game 2", Genre = "Adventure", Platform = "Xbox", Year = 2021 });

            // Привязка списка к ListView
            GamesListView.ItemsSource = Games;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            // код для обработки нажатия кнопки "Назад" здесь

        }

        private void GamesListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class Game
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Platform { get; set; }
        public int Year { get; set; }
    }
}
