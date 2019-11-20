using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMatrix.WebData;
using System.Web.Security;
using System.Data.SqlClient;

namespace RECchatv3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            InitialiseAuthenticationProcess();
        }

        private void InitialiseAuthenticationProcess()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("dbx", "UsersTable", "Username", "Password", true);
                //WebSecurity.CreateUserAndAccount("admin", "admin");
                //Roles.CreateRole("Admin");
                //Roles.CreateRole("SuperModerator");
                //Roles.CreateRole("Moderator");
                //Roles.AddUserToRole("admin", "admin");

            }













        }
    }
}
