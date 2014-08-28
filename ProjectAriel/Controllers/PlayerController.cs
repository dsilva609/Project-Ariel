﻿using System.Net;
using System.Web.Mvc;
using ProjectAriel.DAL;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using ProjectAriel.Services;

namespace ProjectAriel.Controllers
{
	public partial class PlayerController : Controller
	{
		private readonly IUnitOfWork _Uow;
		private readonly PlayerService _Service;

		public PlayerController()
		{
			this._Uow = new UnitOfWork<ProjectArielContext>();
			this._Service = new PlayerService(this._Uow);
		}
		#region HttpGet
		[HttpGet]
		public virtual ActionResult Index()
		{
			return View(this._Service.GetAll());
		}

		[HttpGet]
		public virtual ActionResult Details(int ID)
		{
			var player = this._Service.GetByID(ID);

			if (player == null)
			{
				return HttpNotFound();
			}
			return View(player);
		}

		[HttpGet]
		public virtual ActionResult Create()
		{
			return RedirectToAction(MVC.Player.Edit());
		}

		[HttpGet]
		public virtual ActionResult Edit(int? ID)
		{//TODO should this be nullable?
			var player = new Player();
			ViewBag.Title = "Create Player";

			if (ID > 0)
			{
				player = this._Service.GetByID(ID);
				ViewBag.Title = "Edit Player";
			}

			if (player == null)
			{
				return HttpNotFound();
			}

			return View(player);
		}

		[HttpGet]
		public virtual ActionResult Delete(int ID)
		{
			//if (id == null)
			//{
			//	return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			//}
			var player = this._Service.GetByID(ID);
			if (player == null)
			{
				return HttpNotFound();
			}
			return View(player);
		}

		#endregion

		#region HttpPost

		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Create([Bind(Include = "ID,Name,IsActive")] Player player)
		{
			if (ModelState.IsValid)
			{
				player.IsActive = true;
				this._Service.Add(player);

				return RedirectToAction("Index");
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
				if (ID == 0)
				{
					player.IsActive = true;
					this._Service.Add(player);
				}

				this._Service.Edit(ID, player);

				return RedirectToAction("Index");
			}
			return View(player);
		}
		//TODO is this needed?
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