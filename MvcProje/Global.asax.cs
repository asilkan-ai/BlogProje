using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcProje
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
        protected void  Application_Error(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Server.MapPath("~/Hatalar.txt"), true);
            sw.WriteLine(DateTime.Now.ToString());

            if (Server.GetLastError().InnerException != null)
            {
                sw.WriteLine(Server.GetLastError().InnerException.Message);
            }
            else
                sw.WriteLine(Server.GetLastError().Message);
            sw.Write(Request.RawUrl != null ? Request.RawUrl : "");
            sw.WriteLine();
            sw.Close();
        }
    }
}
