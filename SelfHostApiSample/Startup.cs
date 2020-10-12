using Owin;
using System.Web.Http;
using Unity;
using Unity.AspNet.WebApi;

namespace SelfHostApiSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IValuesRepository, ValuesRepository>();
            config.DependencyResolver = new UnityDependencyResolver(container);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }
    }
}
