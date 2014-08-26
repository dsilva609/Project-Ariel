using ProjectAriel.Components.PlayerComponents;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Services
{
	public class PlayerService
	{
		private IRepository<Player> _Repository;
		private GetPlayerListComponent _getPlayerListComponent;
		private AddPlayerComponent _addPlayerComponent;
		private GetPlayerByIDComponent _getPlayerByIDComponent;
		private EditPlayerComponent _editPlayerComponent;
		private DeletePlayerComponent _deletePlayerComponent;

		public PlayerService(IUnitOfWork uow)
		{
			this._Repository = uow.GetRepository<Player>();
			this._getPlayerListComponent = new GetPlayerListComponent();
			this._addPlayerComponent = new AddPlayerComponent();
			this._getPlayerByIDComponent = new GetPlayerByIDComponent();
			this._editPlayerComponent = new EditPlayerComponent();
			this._deletePlayerComponent = new DeletePlayerComponent();
		}

		public void Add(Player player)
		{
			//this._Repository.Add(player);
			this._addPlayerComponent.Execute(this._Repository, player);
		}

		public IEnumerable<Player> GetAll()
		{
			//return this._Repository.GetAll();
			return this._getPlayerListComponent.Execute(this._Repository);
		}

		public Player GetByID(int? ID)
		{//TODO needs null check
			return this._getPlayerByIDComponent.Execute(this._Repository, ID);
		}

		public void Edit(int ID, Player player)
		{
			//this._Repository.Edit(ID, player);
			this._editPlayerComponent.Execute(this._Repository, player);
		}

		public void Delete(int ID)
		{
			//this._Repository.Delete(ID);
			this._deletePlayerComponent.Execute(this._Repository, ID);
		}
	}
}