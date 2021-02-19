using Autofac;
using System;
using System.Reflection;
using TinyMvvm;
using TinyMvvm.Autofac;
using TinyMvvm.IoC;
using TinyNavigationHelper;
using TinyNavigationHelper.Forms;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFStarter.Helpers;
using XFStarter.IoC;
using Module = Autofac.Module;

namespace XFStarter
{
    public partial class App : Application
    {
        public static IContainer Container;

        public App(Module platformModule)
        {
            InitializeComponent();
            InitializeDependencies(platformModule);

            if(AppInfo.RequestedTheme == AppTheme.Dark)
            {
                ResourcesHelper.SetDarkMode();
            }
            else
            {
                ResourcesHelper.SetLightMode();
            }

            MainPage = new AppShell();
        }

        private void InitializeDependencies(Module platformModule)
        {
            var containerBuilder = new ContainerBuilder();


            containerBuilder.RegisterModule(platformModule);

            var appAssembly = typeof(App).GetTypeInfo().Assembly;
            containerBuilder.RegisterAssemblyTypes(appAssembly)
                   .Where(x => x.IsSubclassOf(typeof(Page)));

            containerBuilder.RegisterAssemblyTypes(appAssembly)
                   .Where(x => x.IsSubclassOf(typeof(ViewModelBase)));

            containerBuilder.RegisterModule(new SharedModule());

            Container = containerBuilder.Build();

            Resolver.SetResolver(new AutofacResolver(Container));


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
