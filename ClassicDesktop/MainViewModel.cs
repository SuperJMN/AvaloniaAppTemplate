using System;
using System.Reactive.Linq;
using Avalonia.Threading;
using ReactiveUI;

namespace ClassicDesktop
{
    public class MainViewModel : ReactiveObject
    {
        private readonly ObservableAsPropertyHelper<string> processedTextHelper;
        private string text;

        public MainViewModel()
        {
            processedTextHelper = this.WhenAnyValue(model => model.Text)
                .Throttle(TimeSpan.FromSeconds(1))
                .ObserveOn(AvaloniaScheduler.Instance)
                .Where(s => s != null)
                .Select(s => $"{s.Length} characters")
                .ToProperty(this, model => model.ProcessedText);
        }

        public string Text
        {
            get { return text; }
            set { this.RaiseAndSetIfChanged(ref text, value); }
        }

        public string ProcessedText => processedTextHelper.Value;
    }
}