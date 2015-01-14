using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UI
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		protected void Session_Start()
		{
			HttpContext.Current.Session.Add("SortAscending", true);
			HttpContext.Current.Session.Add("PlayerSortPreference", "Name");
			HttpContext.Current.Session.Add("PlayerNameSortAscending", true);
		}
	}
}
