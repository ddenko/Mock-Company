using System.Windows;
using Client.Contracts;
using Client.Sales.Proxies;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IUnityContainer _container = new UnityContainer();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //_container.RegisterType<ISalesService, SalesClient>();

            ViewModelLocationProvider.SetDefaultViewModelFactory((type)=>
            {
                return _container.Resolve(type);
            });
        }
    }
}
