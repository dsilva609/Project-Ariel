﻿using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Components.PlayerComponents
{
	public class GetPlayerListComponent
	{
		private IRepository<Player> _repo;

		public GetPlayerListComponent(IRepository<Player> repo)
		{
			this._repo = repo;
		}

		public List<Player> Execute()
		{
			return this._repo.GetAll();
		}
	}
}