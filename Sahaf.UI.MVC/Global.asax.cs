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
         Bir FormsAuthentication kullan�lmas� durumunda kullan�c� sisteme ba�ar�l� bir �ekilde giri� yapt���nda tetiklenen eventtir. Bu sayede kullan�c� herhangi bir sayfaya y�nlendirilebilir, rol atanabilir veya bilgisayar�na cookie b�rak�labilir.

         Sitemizde bulunan herhangi bir sayfay� kullan�c� ziyaret etti�inde �a�r�l�r. �lk sayfa iste�inde �a�r�l�r ve daha sonra �a�r�lmaz. Fakat sessionun timeout s�resi dolmu�sa ve kullan�c� bu s�reden sonra tekrar bir istekte bulunursa yeni kullan�c� gibi davran�l�p bu event tekrar tetiklenir. Kullan�c�n�n�n siteyi ilk ziyareti s�ras�nda yaz�lacak fonksiyonlar burada bulunur. Online kullan�c� say�s� gibi
             */
        protected void Session_Start()
        {
            Session["cart"] = new MyCart();

        }
    }
}
