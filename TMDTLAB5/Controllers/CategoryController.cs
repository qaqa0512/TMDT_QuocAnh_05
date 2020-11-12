using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDTLAB5.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Category(string Category)
        {
            var db = new TMDTLAB5.Models.Entities();
            var ListNews = db.News.Where(c => c.Category.Alias == Category);

            return View(ListNews);
        }
    }
}