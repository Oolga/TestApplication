using iTechArt.TestApplication.DAL;
using iTechArt.TestApplication.DAL.Interfaces;
using iTechArt.TestApplication.DAL.Models;
using iTechArt.TestApplication.Services.Interfaces;
using iTechArtTestApplication.DAL.Interfaces;
using iTechArtTestApplication.Services.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace iTechArt.TestApplication.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult MessageWindow(string message)
        {
            ViewBag.message = message ;
            return PartialView();
        }

    }
}