using ProjectAriel.Common;
using System.Web.Mvc;

namespace ProjectAriel.Controllers
{
	[Authorize(Roles = "Admin")]
	public partial class ElmahController : Controller
	{
		public virtual ActionResult Index(string type)
		{
			return new ElmahResult(type);
		}
	}
}