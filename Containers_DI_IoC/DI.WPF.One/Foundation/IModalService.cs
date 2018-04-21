using System.Windows.Controls;

namespace DI.WPF.One.Foundation
{
    public delegate void BackNavigationEventHandler(bool dialogReturn);

    public interface IModalService
    {
        void NavigateTo(UserControl uc, BackNavigationEventHandler backFromDialog);
        void GoBackward(bool dialogReturnValue);
    }
}
