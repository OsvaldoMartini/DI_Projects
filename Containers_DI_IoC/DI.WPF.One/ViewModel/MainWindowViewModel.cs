using System.ComponentModel;
using System.Windows.Input;
using DI.WPF.One.Commons;
using DI.WPF.One.Interfaces;
using DI.WPF.One.MediatorVM;
using DI.WPF.One.Model;

namespace DI.WPF.One.ViewModel
{
    /// <summary>

    /// The 'ConcreteMediator' class

    /// </summary>

    public class MainWindowViewModel : ViewModelBase, IViewModel, IMainWindowViewModel
    {

        public MainWindowViewModel(ICustomerListViewModel customerListViewModel, ICustomerViewModel customerViewModel)
        {
            _CustomerListViewModel = customerListViewModel;
            _CustomerViewModel = customerViewModel;

            CurrentViewModel = _CustomerViewModel;
            ToggleViewCommand = new CommandBase((p) => OnToggleViewCommand());


        }

        public ICommand ToggleViewCommand { get; private set; }

        public void OnToggleViewCommand()
        {
            if (_CurrentViewModel.Equals(_CustomerListViewModel))
            {
                CurrentViewModel = _CustomerViewModel;
            }
            else
            {
                CurrentViewModel = _CustomerListViewModel;
            }

        }

        #region CustomerListViewModel

        private ICustomerListViewModel _CustomerListViewModel;

        private ICustomerListViewModel CustomerListViewModel
        {
            get { return _CustomerListViewModel; }

            set
            {
                _CustomerListViewModel = value;
                NotifyPropertyChanged(new PropertyChangedEventArgs("CustomerListViewModel"));
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
                NotifyPropertyChanged(new PropertyChangedEventArgs("CustomerViewModel"));
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
                NotifyPropertyChanged(new PropertyChangedEventArgs("CurrentViewModel"));
            }
        }

        #endregion


        #region Model Properies

        private Customer _currentCustomer;

        public Customer CurrentCustomer
        {
            get { return _currentCustomer; }
            set
            {
                _currentCustomer = value;
                NotifyPropertyChanged(new PropertyChangedEventArgs("CurrentCustomer"));
            }
        }

        #endregion
    }

}
