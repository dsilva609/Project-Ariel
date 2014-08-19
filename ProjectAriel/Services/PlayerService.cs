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
			this._getPlayerListComponent = new GetPlayerListComponent(this._Repository);
			this._addPlayerComponent = new AddPlayerComponent(this._Repository);
			this._getPlayerByIDComponent = new GetPlayerByIDComponent(this._Repository);
			this._editPlayerComponent = new EditPlayerComponent(this._Repository);
			this._deletePlayerComponent = new DeletePlayerComponent(this._Repository);
		}

		public void Add(Player player)
		{
			//this._Repository.Add(player);
			this._addPlayerComponent.Execute(player);
		}

		public IEnumerable<Player> GetAll()
		{
			//return this._Repository.GetAll();
			return this._getPlayerListComponent.Execute();
		}

		public Player GetByID(int ID)
		{//TODO needs null check
			//return this._Repository.GetByID(ID);
			return this._getPlayerByIDComponent.Execute(ID);
		}

		public void Edit(int ID, Player player)
		{
			//this._Repository.Edit(ID, player);
			this._editPlayerComponent.Execute(player);
		}

		public void Delete(int ID)
		{
			//this._Repository.Delete(ID);
			this._deletePlayerComponent.Execute(ID);
		}
	}
}