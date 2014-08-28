using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectAriel.DAL;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using ProjectAriel.Services;

namespace ProjectAriel.Controllers
{
	public partial class CardController : Controller
    {
       // private ProjectArielContext db = new ProjectArielContext();

		private readonly IUnitOfWork _Uow;
		private readonly CardService _Service;

		public CardController()
		{
			this._Uow = new UnitOfWork<ProjectArielContext>();
			this._Service = new CardService(this._Uow);
		}

		#region HttpGet
		[HttpGet]
		public virtual ActionResult Index()
        {
            return View(this._Service.GetAll());
        }

		[HttpGet]
		public virtual ActionResult Details(int? ID)
		{
			var card = this._Service.GetByID(ID);

			if (card == null)
			{
				return HttpNotFound();
			}

			return View(card);
		}

		[HttpGet]
		public virtual ActionResult Create()
        {
			return RedirectToAction(MVC.Card.Edit());
        }

		[HttpGet]
		public virtual ActionResult Edit(int? ID)
		{
			//TODO should this be nullable?
			var card = new Card();
			ViewBag.Title = "Create New Card";

			if (ID > 0)
			{
				card = this._Service.GetByID(ID);
				ViewBag.Title = "Edit Card";
			}

			if (card == null)
			{
				return HttpNotFound();
			}

			return View(card);
		}

		[HttpGet]
		public virtual ActionResult Delete(int? ID)
		{
			//if (id == null)
			//{
			//	return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			//}
			var card = this._Service.GetByID(ID);
			if (card == null)
			{
				return HttpNotFound();
			}
			return View(card);
		}
		#endregion

		#region HttpPost
		// POST: Card/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
		public virtual ActionResult Create([Bind(Include = "ID,Name,Description,Type,ImageLocation,IsActive")] Card card)
        {
            if (ModelState.IsValid)
            {
				this._Service.Add(card);

                return RedirectToAction("Index");
            }

            return View(card);
        }

        // POST: Card/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
		public virtual ActionResult Edit([Bind(Include = "ID,Name,Description,Type,ImageLocation,IsActive")] Card card, int ID)
        {
			if (ModelState.IsValid)
			{
				if (ID == 0)
				{
					card.IsActive = true;
					this._Service.Add(card);
				}

				this._Service.Edit(ID, card);

				return RedirectToAction("Index");
			}
			return View(card);
        }

		//TODO is this needed?
		// POST: Card/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public virtual ActionResult DeleteConfirmed(int ID)
		{
			this._Service.Delete(ID);

			return RedirectToAction("Index");
		}
		#endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
			{
				this._Uow.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
