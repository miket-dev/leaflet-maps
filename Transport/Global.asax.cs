using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Transport.OSMReader.Interface;

namespace Transport
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public IKernel Kernel { get; private set; }

		protected void Application_Start()
		{
			this.Kernel = new StandardKernel(
					new OSMNinjectModule()
				);

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		private async Task LoadOSMData()
		{
			await Task.Run(() =>
			{
				this.Kernel.Get<
			});
		}
	}
}
