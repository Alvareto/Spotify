using System.Web.Mvc;

namespace Spotify.Web.Controllers
{
    public class HomeController : SpotifyControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}