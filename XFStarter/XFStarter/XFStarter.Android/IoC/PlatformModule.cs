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

namespace XFStarter.Droid.IoC
{
    public class PlatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            //builder.RegisterType<MyDroidThing>().As<IThing>();

        }
    }
}