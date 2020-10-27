using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyNavigationHelper;
using TinyNavigationHelper.Forms;
using Module = Autofac.Module;

namespace XFStarter.IoC
{
    public class SharedModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var navigationHelper = new ShellNavigationHelper();

            var currentAssembly = Assembly.GetExecutingAssembly();
            navigationHelper.RegisterViewsInAssembly(currentAssembly);

            builder.RegisterInstance<INavigationHelper>(navigationHelper);
        }
    }
}