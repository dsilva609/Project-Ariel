using BusinessLogic.Components.CrudComponents;
using BusinessLogic.Models;
using BusinessLogic.Repositories;
using System.Collections.Generic;

namespace BusinessLogic.Services
{
	public class PlayerService
	{
		private readonly IRepository<Player> _Repository;
		private readonly GetEntityListComponent _getEntityListComponent;
		private readonly AddEntityComponent _addEntityComponent;
		private readonly GetEntityByIDComponent _getEntityByIDComponent;
		private readonly EditEntityComponent _editEntityComponent;
		private readonly DeleteEntityComponent _deleteEntityComponent;

		public PlayerService(IUnitOfWork uow)
		{
			this._Repository = uow.GetRepository<Player>();
			this._getEntityListComponent = new GetEntityListComponent();
			this._addEntityComponent = new AddEntityComponent();
			this._getEntityByIDComponent = new GetEntityByIDComponent();
			this._editEntityComponent = new EditEntityComponent();
			this._deleteEntityComponent = new DeleteEntityComponent();
		}

		public void Add(Player player)
		{
			this._addEntityComponent.Execute(this._Repository, player);
		}

		public IEnumerable<Player> GetAll()
		{
			return this._getEntityListComponent.Execute(this._Repository);
		}

		public Player GetByID(int? ID)
		{//TODO needs null check
			return this._getEntityByIDComponent.Execute(this._Repository, ID);
		}

		public void Edit(int ID, Player player)
		{
			this._editEntityComponent.Execute(this._Repository, player);
		}

		public void Delete(int ID)
		{
			this._deleteEntityComponent.Execute(this._Repository, ID);
		}
	}
}