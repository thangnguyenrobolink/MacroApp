using MacroApp.Modules.Macro;
using MacroApp.Services;
using MacroApp.Services.Interfaces;
using MacroApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace MacroApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MacroModule>();
        }
    }
}
