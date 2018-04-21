using System.Windows;
using Autofac;
using DI.WPF.One.Foundation;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Model;
using DI.WPF.One.Repository;
using DI.WPF.One.ViewModel;

namespace DI.WPF.One
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private static StoreXML storeXML = new StoreXML();
        public static StoreXML StoreXML { get { return storeXML; } }
        internal static Messenger Messenger
        {
            get { return _messenger; }
        }
        readonly static Messenger _messenger = new Messenger();
        
        public static IContainer Container;

        protected override void OnStartup(StartupEventArgs e)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>().PropertiesAutowired();
            builder.RegisterType<CustomerListViewModel>().As<ICustomerListViewModel>();
            builder.RegisterType<CustomerViewModel>().As<ICustomerViewModel>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            
            Container = builder.Build();

            base.OnStartup(e);
        }


    }
}
