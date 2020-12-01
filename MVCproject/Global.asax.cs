using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCproject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
         //  Database.SetInitializer<Models.ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<Models.ApplicationDbContext>());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
