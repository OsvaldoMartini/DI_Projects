using System;
using Container.IoC.Business.Interfaces;
using Container.IoC.Business.Models;

namespace Container.IoC.Business.Concrete
{
    public class Notifier:INotifier
    {
        //send email to customer with receipt
        public void SendReceipt(OrderInfo orderInfo)
        {
            Console.WriteLine(string.Format("Receipt sent to customer '{0}' via email.", DateTime.Now,
                orderInfo));

        }
    }
}
