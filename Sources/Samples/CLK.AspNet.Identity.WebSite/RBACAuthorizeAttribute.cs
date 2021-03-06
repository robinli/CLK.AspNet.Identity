﻿using Microsoft.AspNet.Identity.Owin;
using CLK.AspNet.Identity.WebSite.Models;
using System;
using System.Web;

namespace CLK.AspNet.Identity.WebSite
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class RBACAuthorizeAttribute : CLK.AspNet.Identity.Mvc.RBACAuthorizeAttribute
    {
        // Methods
        protected override PermissionAuthorize GetPermissionAuthorize(HttpContextBase httpContext)
        {
            return new ApplicationPermissionAuthorize(httpContext.GetOwinContext().Get<ApplicationPermissionManager>());
        }
    }
}
