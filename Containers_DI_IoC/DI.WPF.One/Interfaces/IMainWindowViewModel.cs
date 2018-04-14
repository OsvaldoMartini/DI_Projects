using System.Windows.Input;

namespace DI.WPF.One.Interfaces
{

    public interface IMainWindowViewModel : IViewModel
    {
        ICommand ToggleViewCommand { get; }
        IViewModel CurrentViewModel { get; set; }
        void OnToggleViewCommand();
    }
}
