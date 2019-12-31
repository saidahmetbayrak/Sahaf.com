using Sahaf.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sahaf.UI.MVC.Controllers
{
    public class BooksController : Controller
    {
        ICategoryService categoryService;
        IAdvertService advertService;
        public BooksController(ICategoryService category,IAdvertService advert)
        {
            categoryService = category;
            advertService = advert;
        }
        // GET: Books
        public ActionResult Index()
        {
            var categorys = categoryService.GetAll();

            return View(categorys);
        }
    }
}