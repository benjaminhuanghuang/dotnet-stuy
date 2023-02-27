using System.Windows;
using Microsoft.Extensions.Configuration;

namespace PBiLogViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public AppOptions Options { get; }
        public new static App Current => (App)Application.Current;

        public App()
        {
            IConfiguration config = new ConfigurationBuilder()
                    .AddJsonFile("appSettings.json")
                    .Build();

            Options = config.GetSection("Settings").Get<AppOptions>();
            Options ??= new AppOptions();
        }
    }
}
