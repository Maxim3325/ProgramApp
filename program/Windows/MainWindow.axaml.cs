using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using program.Classes;
using program.Pages;
using System;

namespace program
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new MainMenu();
            NavigationSystem.MainFrame = MainFrame;
            LoadData();
        }

        private void LoadData()
        {
            DataSystem.Treners.Add(new Sportsman()
            {
                Name = "Владислав",
                Description = "Мужской",
                BirthDate = DateTime.Parse("12.02.2003")
            });
            DataSystem.Treners.Add(new Sportsman()
            {
                Name = "Матвей",
                Description = "Мужской",
                BirthDate = DateTime.Parse("12.02.2003")
            });
            DataSystem.Sportsmen.Add(new Sportsman()
            {
                Name = "Иван",
                Description = "Мужской",
                BirthDate = DateTime.Parse("12.02.2003")
            });
            DataSystem.Sportsmen.Add(new Sportsman()
            {
                Name = "Даниил",
                Description = "Мужской",
                BirthDate = DateTime.Parse("10.05.1995")
            });
            DataSystem.Sportsmen.Add(new Sportsman()
            {
                Name = "Алексей",
                Description = "Мужской",
                BirthDate = DateTime.Parse("06.10.1983")
            });
        }

            private void exitBtnClick(object? sender, RoutedEventArgs args)
        {
            Close();
        }
    }
}