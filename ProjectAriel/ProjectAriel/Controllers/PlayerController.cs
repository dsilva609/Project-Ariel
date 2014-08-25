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
	public partial class PlayerController : Controller
    {
		private IUnitOfWork _Uow;
		private PlayerService _Service;

		public PlayerController()
		{
			this._Uow = new UnitOfWork<ProjectArielContext>();
			this._Service = new PlayerService(this._Uow);
		}
		
        [HttpGet]
		public virtual ActionResult Index()
        {
			return View(this._Service.GetAll());
        }

        [HttpGet]
		public virtual ActionResult Details(int id)
        {
			var player = this._Service.GetByID(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        [HttpGet]
		public virtual ActionResult Create()
        {
            return View();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
		public virtual ActionResult Create([Bind(Include = "ID,Name,IsActive")] Player player)
        {
            if (ModelState.IsValid)
            {
				this._Service.Add(player);

				return RedirectToAction("Index");
            }

            return View(player);
        }

		[HttpGet]
		public virtual ActionResult Edit(int id)
        {//TODO should this be nullable?
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
			var player = this._Service.GetByID(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
		public virtual ActionResult Edit([Bind(Include = "ID,Name,IsActive")] Player player, int ID)
        {
            if (ModelState.IsValid)
            {
				this._Service.Edit(ID, player);

                return RedirectToAction("Index");
            }
            return View(player);
        }

		[HttpGet]
		public virtual ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
			var player = this._Service.GetByID(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
		public virtual ActionResult DeleteConfirmed(int id)
        {
			this._Service.Delete(id);

			return RedirectToAction("Index");
        }

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
