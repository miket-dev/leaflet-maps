using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace Transport.Extensions
{
	public static class ControllerExtensions
	{
		public static IKernel Kernel(this Controller controller)
		{
			var app = (MvcApplication)HttpContext.Current.ApplicationInstance;

			return app.Kernel;
		}
	}
}