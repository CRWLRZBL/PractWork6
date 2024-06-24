using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;

namespace PractWork6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var games = new List<Games>()
            {
                new Games{IdGame = 1, Name = "Doom", Description = "Адское месилово с чертями", Category = "Shooter", Price= 1400},
                new Games{IdGame = 2, Name = "Dota 2", Description = "Адское месилово с бомжами", Category = "MOBA",Price= 0},
                new Games{IdGame = 3, Name = "HellDivers 2", Description = "КУПИТЕ ЭТО Эдику", Category = "Shooter", Price= 790},
                new Games{IdGame = 4, Name = "The Elder Scrolls V: Skyrim", Description = "Порадуйте беседку", Category = "RPG", Price= 2200},
            };
            gamesDataGrid.ItemsSource = games;

            var categories = new List<string>()
            {
                "RPG",
                "MOBA",
                "Shooter"
            };
            categoryComboBox.ItemsSource = categories;
        }


    }
}

