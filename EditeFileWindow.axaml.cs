using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication2
{
    public partial class EditFileWindow : Window
    {
        public EditFileWindow()
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

        private void EditFileInTableClick(object sender, RoutedEventArgs e)
        {
        }

        private void CancelInputClick(object sender, RoutedEventArgs e)
        {
        }
    }
}