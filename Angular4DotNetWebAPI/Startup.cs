using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

//[assembly: OwinStartup(typeof(Angular4DotNetWebAPI.Startup))]

namespace Angular4DotNetWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           // ConfigureAuth(app);
        }
    }
}
