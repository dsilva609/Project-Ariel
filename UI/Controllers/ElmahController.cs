using UI.Common;
using System.Web.Mvc;

namespace UI.Controllers
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