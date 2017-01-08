using System;
using Avalonia;
using Avalonia.DotNetFrameworkRuntime;

namespace WpfApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UriParser.Register(new ResourceManagerUriParser(), "resm", 0);

            // TODO: Make this work with GTK/Skia/Cairo depending on command-line args
            // again.
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>();
        }      
    }
}