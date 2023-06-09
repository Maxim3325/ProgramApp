using Avalonia.Controls;
using Avalonia.Interactivity;
using program.Classes;
using System;

namespace program.Pages
{
    public partial class SportsmanEdit : UserControl
    {
        private bool isAdd = true;
        public SportsmanEdit(Sportsman sportsman)
        {
            InitializeComponent();
            if (sportsman == null)
            {
                DataContext = new Sportsman();
                GenderCb.SelectedIndex = 0;
            }
            else
            {
                isAdd = false;
                DataContext = sportsman;
                GenderCb.SelectedIndex = (sportsman.Description == "Мужской") ? 0 : 1;
            }
        }

        public SportsmanEdit()
        {
            InitializeComponent();
        }

        private void okBtnClick(object? sender, RoutedEventArgs args)
        {

            if (String.IsNullOrEmpty(NameTb.Text))
            {
                Helper.ShowInfo("Не заполнено имя.");
                return;
            }

            try
            {
                var sportsman = (Sportsman)DataContext;
                sportsman.Description = ((ComboBoxItem)GenderCb.SelectedItem).Content.ToString();
                if (isAdd)
                {
                    DataSystem.Sportsmen.Add(sportsman);
                }
                sportsman.BirthDate.ToString("dd.MM.yyyy");
                NavigationSystem.MainFrame.Content = new DataPage();
            }
            catch(Exception ex)
            {
                Helper.ShowError("Вы не заполнили необходимые поля");
            }
        }

            private void backBtnClick(object? sender, RoutedEventArgs args)
            {
                NavigationSystem.MainFrame.Content = new DataPage();
            }
    }
}
