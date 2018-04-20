using System.Linq;
using System.Windows.Input;
using DI.WPF.One.Commands;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;

namespace DI.WPF.One.ViewModel
{
    public class MainWindowViewModel: ViewModelBase, IViewModel,IMainWindowViewModel
    {
        public ICommand ToggleViewCommand { get; private set; }

        public void OnToggleViewCommand()
        {
            if (_CurrentViewModel.Equals(_CustomerListViewModel))
            {
                Send("Sending Customer Obj", CustomerListViewModel.SelectedCustomerObject);
                CurrentViewModel = _CustomerViewModel;
            }
            else
            {
                CurrentViewModel = _CustomerListViewModel;
            }

        }

        #region CustomerListViewModel
        private ICustomerListViewModel _CustomerListViewModel;
        
        public ICustomerListViewModel CustomerListViewModel
        {
            get { return _CustomerListViewModel; }

            set
            {
                _CustomerListViewModel = value;
                SetPropertyChanged("CustomerListViewModel");
            }
        }
        #endregion

        #region  CustomerViewModel
        private ICustomerViewModel _CustomerViewModel;
        public ICustomerViewModel CustomerViewModel
        {
            get { return _CustomerViewModel; }

            set
            {
                _CustomerViewModel = value;
                SetPropertyChanged("CustomerViewModel");
            }
        }
        #endregion


        #region CurrentViewModel;

        public IViewModel _CurrentViewModel;

        public IViewModel CurrentViewModel
        {
            get { return _CurrentViewModel; }

            set
            {
                _CurrentViewModel = value;
                SetPropertyChanged("CurrentViewModel");
            }
        }
        #endregion

        public MainWindowViewModel(ICustomerListViewModel customerListViewModel, ICustomerViewModel customerViewModel)
        {

            _CustomerListViewModel = customerListViewModel;
            _CustomerViewModel = customerViewModel;

            CurrentViewModel = _CustomerViewModel;
            ToggleViewCommand = new ToggleViewCommand((p) => OnToggleViewCommand());


        }

    }

}
