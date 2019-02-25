using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace NormalWebformPage
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            HttpApplication objApp = new HttpApplication();
            
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void application_end()
        {
            // destory session and cloing 
        }
       void session_start()
        {
           //HttpServerUtility objsesssion = new HttpServerUtility()
        }
        //void session_end()
    }
}