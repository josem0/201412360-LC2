﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2014102360_MVC.Startup))]
namespace _2014102360_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
