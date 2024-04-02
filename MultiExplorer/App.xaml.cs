using System.Windows;

using MultiExplorer.Modules.ModuleName;
using MultiExplorer.Services;
using MultiExplorer.Services.Interfaces;
using MultiExplorer.Views;

using Prism.Ioc;
using Prism.Modularity;

namespace MultiExplorer
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
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
