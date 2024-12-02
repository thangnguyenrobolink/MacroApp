using MacroApp.Core;
using MacroApp.Modules.Macro.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MacroApp.Modules.Macro
{
    public class MacroModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MacroModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.MacroRegion, "MacroView");
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "MacroView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MacroView>();
        }
    }
}