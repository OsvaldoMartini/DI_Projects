using System;
using UIAutomationController.Util;

namespace UIAutomationController.ViewModel
{
    public class WindowTitleVmCollection : NotifyObservableCollection<WindowTitleVM>
    {
        
        public WindowTitleVmCollection(Action itemPropertyChanged) : base(itemPropertyChanged)
        {
            this.Add(new WindowTitleVM { WindowTitle = "UI Automation Test Window" });
            this.Add(new WindowTitleVM { WindowTitle = "DI WPF One" });
            this.Add(new WindowTitleVM { WindowTitle = "User Control Toggle" });
        }
    }
}
