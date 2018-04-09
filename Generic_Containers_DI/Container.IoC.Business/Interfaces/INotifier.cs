using Container.IoC.Business.Models;

namespace Container.IoC.Business.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
