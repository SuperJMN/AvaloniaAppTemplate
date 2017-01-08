using Avalonia;
using OmniXaml.Avalonia;

namespace ClassicDesktop
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public override void Initialize()
        {
            XamlService.Current.Load(this);
        }
    }
}
