using ProjectAriel.DAL;
using ProjectAriel.Repositories;
using ProjectAriel.Services;
using System.Web.Mvc;

namespace ProjectAriel.Controllers
{
	public partial class GameController : Controller
	{
		private readonly IUnitOfWork _Uow;
		private readonly CardService _CardService;

		public GameController()
		{
			this._Uow = new UnitOfWork<ProjectArielContext>();
			this._CardService = new CardService(this._Uow);
		}

		#region HttpGet
		[HttpGet]
		public virtual ActionResult Index()
		{
			var cards = this._CardService.GetAll();

			return View(cards);
		}
		#endregion
	}
}
