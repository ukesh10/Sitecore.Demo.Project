﻿using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.DemoProject.MVC.Web.Controllers
{
    public class HeroController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            var dataSourceItem = RenderingContext.Current.Rendering.Item;
            return View("~/Views/Gymster/Components/HeroController.cshtml",dataSourceItem);
        }
    }
}