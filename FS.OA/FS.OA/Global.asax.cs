using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FS.OA
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            var builder = RegisterAll();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public ContainerBuilder RegisterAll()
        {
            var builder = new ContainerBuilder();
            Assembly[] assemblies = Directory.GetFiles(AppDomain.CurrentDomain.RelativeSearchPath, "FS.OA.dll").Select(Assembly.LoadFrom).ToArray();
            Type baseType = typeof(IDependencyResolver);
            builder.RegisterAssemblyTypes(assemblies)
            .Where(type => baseType.IsAssignableFrom(type) && !type.IsAbstract)
            .AsSelf().AsImplementedInterfaces()
            .PropertiesAutowired().InstancePerLifetimeScope();
            builder.RegisterControllers(assemblies).PropertiesAutowired();
            return builder;
        }
    }
}
