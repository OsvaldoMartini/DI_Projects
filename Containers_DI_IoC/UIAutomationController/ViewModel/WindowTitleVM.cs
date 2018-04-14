using DI.WPF.One.Interfaces;
namespace UIAutomationController.ViewModel
{
    public class WindowTitleVM : ViewModelBase
    {

        private string _WindowTitle { get; set; }

        public string WindowTitle
        {
            get {
                return _WindowTitle;
            }
            set
            {
                _WindowTitle = value;
                SetPropertyChanged("WidowTitle");
            }

        }

    }
}
