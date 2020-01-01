using Sahaf.UI.MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sahaf.UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        /*
         ***** SESSION START ****
         Bir FormsAuthentication kullanýlmasý durumunda kullanýcý sisteme baþarýlý bir þekilde giriþ yaptýðýnda tetiklenen eventtir. Bu sayede kullanýcý herhangi bir sayfaya yönlendirilebilir, rol atanabilir veya bilgisayarýna cookie býrakýlabilir.

         Sitemizde bulunan herhangi bir sayfayý kullanýcý ziyaret ettiðinde çaðrýlýr. Ýlk sayfa isteðinde çaðrýlýr ve daha sonra çaðrýlmaz. Fakat sessionun timeout süresi dolmuþsa ve kullanýcý bu süreden sonra tekrar bir istekte bulunursa yeni kullanýcý gibi davranýlýp bu event tekrar tetiklenir. Kullanýcýnýnýn siteyi ilk ziyareti sýrasýnda yazýlacak fonksiyonlar burada bulunur. Online kullanýcý sayýsý gibi
             */
        protected void Session_Start()
        {
            Session["cart"] = new MyCart();

        }
    }
}
