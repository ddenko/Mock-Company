using System;
using System.Linq;
using System.ServiceModel;
using Autofac;
using Autofac.Integration.Wcf;
using Business.Managers;
using Data.Repositories;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = null;
            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterAssemblyTypes(typeof(SalesRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .As(t => t.GetInterfaces().FirstOrDefault(
                    i => i.Name == "I" + t.Name));

            containerBuilder.RegisterType<SalesManager>();

            container = containerBuilder.Build();

            ServiceHost hostSalesManager = new ServiceHost(typeof(SalesManager));

            hostSalesManager.AddDependencyInjectionBehavior(typeof(SalesManager), container);

            hostSalesManager.Open();

            Console.WriteLine("Services started. Press [Enter] to exit.");
            Console.ReadLine();

            hostSalesManager.Close();
        }
    }
}
