using StoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.Web.Attributes
{
    public class CustomAuthorizationAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            string[] allowedRoles = this.Roles.Split(',');
            //StoreAppContext context = new StoreAppContext();
            //var currentUserRoles = context.Users.FirstOrDefault(user => user.UserName == filterContext.HttpContext.User.Identity.Name).Roles;
            //List<string> roles = new List<string>();
            //foreach (var userRole in currentUserRoles)
            //{
            //    string role = context.Roles.FirstOrDefault(r => r.Id == userRole.RoleId).Name;
            //    roles.Add(role);
            //}

            if (filterContext.HttpContext.Request.IsAuthenticated && !allowedRoles.Any(filterContext.HttpContext.User.IsInRole))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/_LoginPartial.cshtml"
                };
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}