using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddFileClick(object sender, RoutedEventArgs e)
        {
            NewFileWindow newFileWindow = new NewFileWindow();
            newFileWindow.Show();
        }
        
        private void CreateOutputFileClick(object sender, RoutedEventArgs e)
        {
        }
    }
}