using Sahaf.BLL.Abstract;
using Sahaf.UI.MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Controllers
{
    public class CartController : Controller
    {
        IAdvertService advertService;
        public CartController(IAdvertService advert)
        {
            advertService = advert;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _CartList()
        {
            return PartialView();
        }
        public ActionResult _CartButton()
        {
            return PartialView();
        }

        public ActionResult AddToCart(int id)
        {
            //MyCart myCart = new MyCart(); bu kullanım bana sürekli yeni sepetler oluşturur.
            MyCart cart = Session["cart"] as MyCart;
            CartItem cartItem = new CartItem();
            var eklenenUrun = advertService.GetAll().Where(x => x.ID == id).SingleOrDefault();
            cartItem.ID = eklenenUrun.ID;
            cartItem.BookName = eklenenUrun.BookName;
            cartItem.Writer = eklenenUrun.Writer;
            cartItem.Price = eklenenUrun.Price;
            if (string.IsNullOrEmpty(eklenenUrun.AdvertİmgUrl))
            {
                cartItem.ImageUrl = null;
            }
            else
            {
                cartItem.ImageUrl = eklenenUrun.AdvertİmgUrl;
            }
            cartItem.Quantity = 1;

            //cartItem.SubTotal
            //cartItem.ID = eklenenUrun.ID;
            //cartItem.Name = eklenenUrun.Title;
            //cartItem.Price = eklenenUrun.Price;
            //cartItem.Amount = 1;

            cart.Add(cartItem);
            Session["cart"] = cart;

            return PartialView("_CartButton");
        }
        public ActionResult UpdateCart(short quantity, int id)
        {
            MyCart guncellenenSepet = Session["cart"] as MyCart;
            guncellenenSepet.Update(id, quantity);
            Session["cart"] = guncellenenSepet;

            return RedirectToAction("_CartList", "Cart");
        }

        public ActionResult DeleteItemCart(int id)
        {
            MyCart silinecekSepet = Session["cart"] as MyCart;
            silinecekSepet.Delete(id);
            Session["cart"] = silinecekSepet;

            return RedirectToAction("_CartList", "Cart");
        }
    }
}