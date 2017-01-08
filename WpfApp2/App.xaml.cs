using Avalonia;
using OmniXaml.Avalonia;

namespace WpfApp2
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
