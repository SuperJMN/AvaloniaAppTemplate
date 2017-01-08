using System;
using Avalonia;
using Avalonia.DotNetFrameworkRuntime;

namespace ClassicDesktop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UriParser.Register(new ResourceManagerUriParser(), "resm", 0);
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>();
        }      
    }
}