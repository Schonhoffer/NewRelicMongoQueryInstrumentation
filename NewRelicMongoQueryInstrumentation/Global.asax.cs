using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Nancy;

namespace NewRelicMongoQueryInstrumentation
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            StaticConfiguration.DisableErrorTraces = false;
        }
    }
}