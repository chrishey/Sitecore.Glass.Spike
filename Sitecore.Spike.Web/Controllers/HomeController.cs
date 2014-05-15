using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Spike.Web.Models;

namespace Sitecore.Spike.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var context = new SitecoreContext();
            var model = context.GetCurrentItem<Homepage>();

            return View(model);
        }

        public ActionResult News()
        {
            var context = new SitecoreContext();
            var model = context.GetCurrentItem<Homepage>().News;

            return View("RelatedNews", model);
        }
	}
}