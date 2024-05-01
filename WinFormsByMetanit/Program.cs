using Autofac;
using Autofac.Core.Lifetime;
using Autofac.Extensions.DependencyInjection;
using System.Security.Cryptography.X509Certificates;
using WinFormsByMetanit.Dal;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Dal.Repositories;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Service.Implementations;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit
{
    internal static class Program
    {
        public static IContainer Container;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container = Configure();

            using (var lifetimeScope = Container.BeginLifetimeScope())
            {
                var userService = lifetimeScope.Resolve<IUserService>();
                var orderService = lifetimeScope.Resolve<IOrderService>();
                var clientService = lifetimeScope.Resolve<IClientService>();
                var materialService = lifetimeScope.Resolve<IMaterialService>();
                Application.Run(new AddOrderForm(orderService, clientService, materialService));
                Application.Run(new DataGridView(Container.Resolve<IMaterialService>(),
                                                           Container.Resolve<IClientService>(),
                                                           Container.Resolve<IOrderService>()));
                Application.Run(new AddOrderForm(Container.Resolve<IOrderService>(),
                                                    Container.Resolve<IClientService>(),
                                                    Container.Resolve<IMaterialService>()));




                Application.Run(new MainForm());
                Application.Run(new LoginForm(Container.Resolve<IUserService>()));
                //Application.Run(new OrderForm(
                //    Container.Resolve<IOrderService>(),
                //    Container.Resolve<IMaterialRepository>(),
                //    Container.Resolve<IOrderRepository>(),
                //    Container.Resolve<IUserService>(),
                //    Container.Resolve<IUserRepository>()));
            }
        }
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<WindowDbContext>().As<WindowDbContext>().InstancePerLifetimeScope();

            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<OrderDetailsRepository>().As<IOrderDatailsRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<MaterialRepository>().As<IMaterialRepository>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<MaterialService>().As<IMaterialService>();


            builder.RegisterType<LoginForm>();
            builder.RegisterType<MainForm>();
            builder.RegisterType<AddOrderForm>();

            return builder.Build();
        }
        
    }
}