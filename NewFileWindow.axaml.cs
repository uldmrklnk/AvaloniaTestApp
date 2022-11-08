using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication2
{
    public partial class NewFileWindow : Window
    {
        public NewFileWindow()
        {
            InitializeComponent();
        }

        private async void OnBrowseClick(object sender, RoutedEventArgs e)
        {
            var dialogWindow = new OpenFileDialog();
            var inputFile = await dialogWindow.ShowAsync(new Window());
            if (inputFile != null)
            filePath.Text = inputFile[0];
        }

        private void AddFileToTableClick(object sender, RoutedEventArgs e)
        {
        }

        private void CancelInputClick(object sender, RoutedEventArgs e)
        {
        }
    }
}