﻿using System;
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
    {//TODO delete this
        //private ProjectArielContext db = new ProjectArielContext();

		private IUnitOfWork _Uow;
		private PlayerService _Service;

		public PlayerController()
		{
			this._Uow = new UnitOfWork<ProjectArielContext>();
			this._Service = new PlayerService(this._Uow);
		}
		//IUnitOfWork uow = new UnitOfWork<ProjectArielContext>();
		//PlayerService service = new PlayerService(uow);

        // GET: Player
		public virtual ActionResult Index()
        {
			
			//return View(db.Players.ToList());

			return View(this._Service.GetAll());
        }

        // GET: Player/Details/5
		public virtual ActionResult Details(int id)
        {//TODO does this have to be nullable?
			//if (id == null)
			//{
			//	return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			//}
			var player = this._Service.GetByID(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Player/Create
		public virtual ActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
		public virtual ActionResult Create([Bind(Include = "ID,Name,IsActive")] Player player)
        {
            if (ModelState.IsValid)
            {
				this._Service.Add(player);
				

				//db.Players.Add(player);
				//db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(player);
        }

        // GET: Player/Edit/5
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

        // POST: Player/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
		public virtual ActionResult Edit([Bind(Include = "ID,Name,IsActive")] Player player, int ID)
        {
            if (ModelState.IsValid)
            {
				this._Service.Edit(ID, player);
                //db.Entry(player).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        // GET: Player/Delete/5
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

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
		public virtual ActionResult DeleteConfirmed(int id)
        {
			//Player player = db.Players.Find(id);
			//db.Players.Remove(player);
			//db.SaveChanges();
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
