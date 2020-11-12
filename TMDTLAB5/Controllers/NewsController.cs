using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDTLAB5.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult News(string Category, string Alias)
        {
            var db = new TMDTLAB5.Models.Entities();
            var ListNews = db.News.Where(c => c.Category.Alias == Category && c.Alias == Alias);

            return View(ListNews);
        }
    }
}