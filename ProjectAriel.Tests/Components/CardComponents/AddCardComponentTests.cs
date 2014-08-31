using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectAriel.Components.CardComponents;
using ProjectAriel.Enums;
using ProjectAriel.Models;
using ProjectAriel.Repositories;

namespace ProjectAriel.Tests.Components.CardComponents
{
	[TestClass]
	public class AddCardComponentTests
	{
		private IRepository<Card> _repo;
		private AddCardComponent _addCardComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._addCardComponent = new AddCardComponent();
			this._card = new Card
			{
				Name = "Bang!",
				ID = 1,
				Description = "Kill 'Em All",
				Suit = Suit.Spade,
				Rank = Rank.Ace,
				Cardtype = CardType.Basic,
				IsActive = true
			};
			this._mock = new Mock<IRepository<Card>>();
		}

		[TestMethod]
		public void TestThatANewCardIsAddedToTheRepository()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._card));
			this._repo = this._mock.Object;

			//--Act
			this._addCardComponent.Execute(this._repo, this._card);

			//--Assert
			this._mock.Verify(m => m.Add(It.Is<Card>(c => c.ID == this._card.ID && c.Name == this._card.Name && c.IsActive == this._card.IsActive)));
		}
	}
}
