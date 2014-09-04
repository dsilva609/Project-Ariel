using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectAriel.Components.CrudComponents;
using ProjectAriel.Enums;
using ProjectAriel.Models;
using ProjectAriel.Repositories;

namespace ProjectAriel.Tests.Components.CrudComponents
{
	[TestClass]
	public class AddEntityComponentTests
	{
		private IRepository<Card> _repo;
		private AddEntityComponent _addEntityComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._addEntityComponent = new AddEntityComponent();
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
		public void TestThatANewIsAddedToTheRepository()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._card));
			this._repo = this._mock.Object;

			//--Act
			this._addEntityComponent.Execute(this._repo, this._card);

			//--Assert
			this._mock.Verify(m => m.Add(It.Is<Card>(c => c.ID == this._card.ID && c.Name == this._card.Name && c.IsActive == this._card.IsActive)));
		}
	}
}
