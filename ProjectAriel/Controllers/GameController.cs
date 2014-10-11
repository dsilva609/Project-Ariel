using System.Web.Mvc;

namespace ProjectAriel.Controllers
{
	public partial class GameController : Controller
	{
		[HttpGet]
		public virtual ActionResult Index()
		{
			return View();
		}
	}
}
