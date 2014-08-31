using ProjectAriel.Components.CardComponents;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using System.Collections.Generic;

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

		public void ConvertEnums(Card card)
		{
			switch (card.Cardtype)
			{
				case ProjectAriel.Enums.CardType.Default:
					card.CardTypeString = "";
					break;
				case ProjectAriel.Enums.CardType.Basic:
					card.CardTypeString = "Basic";
					break;
				case ProjectAriel.Enums.CardType.Alcohol:
					card.CardTypeString = "Alcohol";
					break;
				case ProjectAriel.Enums.CardType.Draw:
					card.CardTypeString = "Draw";
					break;
				case ProjectAriel.Enums.CardType.TimeDelay:
					card.CardTypeString = "Time Delay";
					break;
				case ProjectAriel.Enums.CardType.Weapon:
					card.CardTypeString = "Weapon";
					break;
				case ProjectAriel.Enums.CardType.Equipment:
					card.CardTypeString = "Equipment";
					break;
				case ProjectAriel.Enums.CardType.TargetAll:
					card.CardTypeString = "Target All";
					break;
				default:
					break;
			}

			switch (card.Suit)
			{
				case ProjectAriel.Enums.Suit.Default:
					card.SuitString = "";
					break;
				case ProjectAriel.Enums.Suit.Heart:
					card.SuitString = "Heart";
					break;
				case ProjectAriel.Enums.Suit.Diamond:
					card.SuitString = "Diamond";
					break;
				case ProjectAriel.Enums.Suit.Club:
					card.SuitString = "Club";
					break;
				case ProjectAriel.Enums.Suit.Spade:
					card.SuitString = "Spade";
					break;
				default:
					break;
			}

			switch (card.Rank)
			{
				case ProjectAriel.Enums.Rank.Default:
					card.RankString = "";
					break;
				case ProjectAriel.Enums.Rank.One:
					card.RankString = "One";
					break;
				case ProjectAriel.Enums.Rank.Two:
					card.RankString = "Two";
					break;
				case ProjectAriel.Enums.Rank.Three:
					card.RankString = "Three";
					break;
				case ProjectAriel.Enums.Rank.Four:
					card.RankString = "Four";
					break;
				case ProjectAriel.Enums.Rank.Five:
					card.RankString = "Five";
					break;
				case ProjectAriel.Enums.Rank.Six:
					card.RankString = "Six";
					break;
				case ProjectAriel.Enums.Rank.Seven:
					card.RankString = "Seven";
					break;
				case ProjectAriel.Enums.Rank.Eight:
					card.RankString = "Eight";
					break;
				case ProjectAriel.Enums.Rank.Nine:
					card.RankString = "Nine";
					break;
				case ProjectAriel.Enums.Rank.Ten:
					card.RankString = "Ten";
					break;
				case ProjectAriel.Enums.Rank.Jack:
					card.RankString = "Jack";
					break;
				case ProjectAriel.Enums.Rank.Queen:
					card.RankString = "Queen";
					break;
				case ProjectAriel.Enums.Rank.King:
					card.RankString = "King";
					break;
				case ProjectAriel.Enums.Rank.Ace:
					card.RankString = "Ace";
					break;
				default:
					break;
			}
		}
	}
}