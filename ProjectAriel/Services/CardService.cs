using ProjectAriel.Components.CardComponents;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Services
{
	public class CardService
	{
		private readonly IRepository<Card> _Repository;
		private readonly GetCardListComponent _getCardListComponent;
		private readonly AddCardComponent _addCardComponent;
		private readonly GetCardByIDComponent _getCardByIDComponent;
		private readonly EditCardComponent _editCardComponent;
		private readonly DeleteCardComponent _deleteCardComponent;

		public CardService(IUnitOfWork uow)
		{
			this._Repository = uow.GetRepository<Card>();
			this._getCardListComponent = new GetCardListComponent();
			this._addCardComponent = new AddCardComponent();
			this._getCardByIDComponent = new GetCardByIDComponent();
			this._editCardComponent = new EditCardComponent();
			this._deleteCardComponent = new DeleteCardComponent();
		}

		public void Add(Card card)
		{
			this._addCardComponent.Execute(this._Repository, card);
		}

		public IEnumerable<Card> GetAll()
		{
			return this._getCardListComponent.Execute(this._Repository);
		}

		public Card GetByID(int? ID)
		{//TODO needs null check
			return this._getCardByIDComponent.Execute(this._Repository, ID);
		}

		public void Edit(int ID, Card card)
		{
			this._editCardComponent.Execute(this._Repository, card);
		}

		public void Delete(int ID)
		{
			this._deleteCardComponent.Execute(this._Repository, ID);
		}
	}
}