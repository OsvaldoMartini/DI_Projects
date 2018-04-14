using System.Windows;
using Autofac;
using DI.WPF.One.Interfaces;

namespace DI.WPF.One
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            IMainWindowViewModel viewModel = App.Container.Resolve<IMainWindowViewModel>();

            this.DataContext = viewModel;

        }
    }
}
