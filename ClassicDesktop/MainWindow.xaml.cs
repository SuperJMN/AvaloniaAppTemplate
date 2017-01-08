using Avalonia.Controls;
using OmniXaml.Avalonia;

namespace ClassicDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            XamlService.Current.Load(this);
        }
    }
}
