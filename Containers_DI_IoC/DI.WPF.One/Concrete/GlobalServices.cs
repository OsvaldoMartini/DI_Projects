using System.Windows;
using DI.WPF.One.Interfaces;

namespace DI.WPF.One.Concrete
{
    public class GlobalServices
    {
        public static IModalService ModalService
        {
            get { return (IModalService)Application.Current.MainWindow; }
        }
    }
}
