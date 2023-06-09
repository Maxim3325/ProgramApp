using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using program.Classes;

namespace program.Pages
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void dataBtnClick(object? sender, RoutedEventArgs e)
        {
            NavigationSystem.MainFrame.Content = new DataPage();
        }
    }
}
