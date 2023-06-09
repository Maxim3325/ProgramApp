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
            GenderCb.Items = DataSystem.Description;
            if (sportsman == null)
            {
                DataContext = new Sportsman();
                GenderCb.SelectedIndex = 0;
            }
            else
            {
                isAdd = false;
                DataContext = sportsman;
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
                Helper.ShowInfo("�� ��������� ���.");
                return;
            }

            try
            {
                var sportsman = (Sportsman)DataContext;
                if (isAdd)
                {
                    DataSystem.Sportsmen.Add(sportsman);
                }
                sportsman.BirthDate.ToString("dd.MM.yyyy");
                NavigationSystem.MainFrame.Content = new DataPage();
            }
            catch(Exception ex)
            {
                Helper.ShowError("�� �� ��������� ����������� ����");
            }
        }

            private void backBtnClick(object? sender, RoutedEventArgs args)
            {
                NavigationSystem.MainFrame.Content = new DataPage();
            }
    }
}
