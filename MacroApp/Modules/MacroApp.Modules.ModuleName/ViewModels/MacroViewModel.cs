using MacroApp.Core.Mvvm;
using MacroApp.Services.Interfaces;
using Prism.Regions;

namespace MacroApp.Modules.Macro.ViewModels
{
    public class MacroViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public MacroViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //
        }
    }
}
