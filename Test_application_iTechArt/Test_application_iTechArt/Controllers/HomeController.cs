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