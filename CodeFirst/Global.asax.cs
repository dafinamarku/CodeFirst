﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CodeFirst
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
    protected void Application_Error()
    {
      Exception exec = Server.GetLastError();
      string s = "Message:  " + exec.Message + ", Type: " 
        + exec.GetType().ToString() + ", Source:  " 
        + exec.Source;
      StreamWriter sw = File.AppendText(HttpContext.Current.Request.PhysicalApplicationPath +
        "\\ErrorLog.txt");
      sw.WriteLine(s);
      sw.Close();
    }
  }
}
