using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Paathshaala_SPA.Startup))]

namespace Paathshaala_SPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            LoggingExtensions.Logging.Log.InitializeWith<LoggingExtensions.log4net.Log4NetLog>();
            ConfigureAuth(app);
        }
    }
}
