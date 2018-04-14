using System.Windows.Input;
using DI.WPF.One.Commands;
using DI.WPF.One.Interfaces;

namespace DI.WPF.One.ViewModel
{
    public class MainWindowViewModel: ViewModelBase, IViewModel,IMainWindowViewModel
    {
        public ICommand ToggleViewCommand { get; private set; }
        public void OnToggleViewCommand()
        {
            if (_CurrentViewModel.Equals(_CustomerListViewModel))
                CurrentViewModel = _CustomerViewModel;
            else
            {
                CurrentViewModel = _CustomerListViewModel;
            }
        }

        private ICustomerListViewModel _CustomerListViewModel;
        public IViewModel _CurrentViewModel;

        public ICustomerListViewModel CustomerListViewModel
        {
            get { return _CustomerListViewModel; }

            set
            {
                _CustomerListViewModel = value;
                SetPropertyChanged("CustomerListViewModel");
            }
        }
        private ICustomerViewModel _CustomerViewModel;
        
        
        public IViewModel CurrentViewModel
        {
            get { return _CurrentViewModel; }

            set
            {
                _CurrentViewModel = value;
                SetPropertyChanged("CurrentViewModel");
            }
        }
        

        public MainWindowViewModel(ICustomerListViewModel customerListViewModel, ICustomerViewModel customerViewModel)
        {

            _CustomerListViewModel = customerListViewModel;
            _CustomerViewModel = customerViewModel;

            CurrentViewModel = _CustomerListViewModel;
            ToggleViewCommand = new ToggleViewCommand((p) => OnToggleViewCommand());


        }

    }

}
