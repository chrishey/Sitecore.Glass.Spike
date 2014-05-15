using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Spike.Web.Models;

namespace Sitecore.Spike.Web.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetArticle()
        {
            var context = new SitecoreContext();
            var model = context.GetCurrentItem<NewsArticle>();

            return View("Article", model);
        }
	}
}