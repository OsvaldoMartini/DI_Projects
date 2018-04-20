using System.Windows;
using Autofac;
using DI.WPF.One.Interfaces;
using DI.WPF.One.Repository;
using DI.WPF.One.ViewModel;

namespace DI.WPF.One
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static IContainer Container;

        protected override void OnStartup(StartupEventArgs e)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>().PropertiesAutowired();
            builder.RegisterType<CustomerListViewModel>().As<ICustomerListViewModel>();
            builder.RegisterType<CustomerViewModel>().As<ICustomerViewModel>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            
            //builder.RegisterType<ConcreteMediator>();
            //builder.Register<CustomerViewModel>(b => new CustomerViewModel(b.Resolve<CustomerRepository>()));
            //builder.Register<ConcreteMediator>(b => new ConcreteMediator(b.Resolve<CustomerViewModel>()));
            //builder.Register<CustomerListViewModel>(b => new CustomerListViewModel(b.Resolve<ConcreteMediator>()))

            Container = builder.Build();

            base.OnStartup(e);
        }


    }
}
