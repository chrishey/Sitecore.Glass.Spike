using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Spike.Web.Models;

namespace Sitecore.Spike.Web.Controllers
{
    public class NavigationController : Controller
    {
        //
        // GET: /Navigation/
        public ActionResult Index()
        {
            var context = new SitecoreContext();
            var model = context.GetHomeItem<MenuItem>();

            return View("Navigation", model);
        }
	}
}