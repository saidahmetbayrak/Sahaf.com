using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.FiltersCustom
{
    public class AdminAuthorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //kullanıcı girişi varken nasıl davranacağını belirtiriz
            if (HttpContext.Current.Session["kullanici"] != null)
            {
                User currentUser = HttpContext.Current.Session["kullanici"] as User;
                if (currentUser.RoleID != 3)//3 ADMIN
                {
                    return false;
                }
                return true;
            }
            return false;

        }


        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //kullanıcı girişi yokken nasıl davranacağını belirtiriz
            //filterContext.Result = new RedirectResult("/Account/Login");
            if (HttpContext.Current.Session["kullanici"] != null)
            {
                User currentUser = HttpContext.Current.Session["kullanici"] as User;
                if (currentUser.RoleID != 3)//3 ADMIN
                {
                    filterContext.Result = new RedirectResult("/Admin/Home/Login");
                }
            }
            else
            {
                filterContext.Result = new RedirectResult("/Admin/Home/Login");
            }
        }
    }
}