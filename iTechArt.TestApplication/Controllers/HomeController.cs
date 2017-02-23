using System.Web.Mvc;


namespace iTechArt.TestApplication.Controllers
{
    public class HomeController : Controller
    {
		[HttpGet]
		public ActionResult MessageWindow(string message)
        {
            ViewBag.message = message ;
            return PartialView();
        }

    }
}