using Avalonia.Controls;
using Avalonia.Interactivity;
using MessageBox.Avalonia;
using program.Classes;
using System.Collections.Generic;

namespace program.Pages
{
    public partial class DataPage : UserControl
    {
        public DataPage()
        {
            InitializeComponent();
            loadData();
        }

        private void searchTbKeyUp(object? sender, Avalonia.Input.KeyEventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            if (string.IsNullOrEmpty(SearchTb.Text))
            {
                SportsmenDG.Items = DataSystem.Sportsmen;
            }
            else
            {
                var filteredSportsmen = new List<Sportsman>();
                foreach (var el in DataSystem.Sportsmen)
                {
                    if (el.Name.Contains(SearchTb.Text))
                    {
                        filteredSportsmen.Add(el);
                    }
                }
                SportsmenDG.Items = filteredSportsmen;
            }
        }

        private void backBtnClick(object? sender, RoutedEventArgs e)
        {
            NavigationSystem.MainFrame.Content = new MainMenu();
        }

        private void addSportsmanBtnClick(object? sender, RoutedEventArgs args)
        {
            NavigationSystem.MainFrame.Content = new SportsmanEdit(null);
        }

        private void editSportsmanBtnClick(object? sender, RoutedEventArgs args)
        {
            var selectedSportsman = (Sportsman)SportsmenDG.SelectedItem;
            if (selectedSportsman == null)
            {
                Helper.ShowInfo("Выберите спортсмена");
                return;
            }
            NavigationSystem.MainFrame.Content = new SportsmanEdit(selectedSportsman);
        }

        private void addTrenerBtnClick(object? sender, RoutedEventArgs args)
        {
            NavigationSystem.MainFrame.Content = new SportsmanEdit();
        }

        private async void deleteSportsmanBtnClick(object? sender, RoutedEventArgs args)
        {
            var selectedSportsman = (Sportsman)SportsmenDG.SelectedItem;
            if (selectedSportsman == null)
            {
                Helper.ShowInfo("Выберите спортсмена");
                return;
            }
            var answer = await MessageBoxManager.GetMessageBoxStandardWindow("Вопрос", "Вы уверены?",
                MessageBox.Avalonia.Enums.ButtonEnum.YesNo, MessageBox.Avalonia.Enums.Icon.Question).Show();
            if (answer == MessageBox.Avalonia.Enums.ButtonResult.Yes)
            {
                DataSystem.Sportsmen.Remove(selectedSportsman);
            }
        }
    }
}
