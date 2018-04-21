using System.Windows;

namespace DI.WPF.One.Foundation
{
    public class GlobalServices
    {
        public static IModalService ModalService
        {
            get { return (IModalService)Application.Current.MainWindow; }
        }
    }
}
