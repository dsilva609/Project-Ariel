using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectAriel.Components.CrudComponents;
using ProjectAriel.Enums;
using ProjectAriel.Models;
using ProjectAriel.Repositories;

namespace ProjectAriel.Tests.Components.CrudComponents
{
	[TestClass]
	public class GetEntityByIDComponentTests
	{
		private IRepository<Card> _repo;
		private GetEntityByIDComponent _getEntityByIDComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._getEntityByIDComponent = new GetEntityByIDComponent();
			this._mock = new Mock<IRepository<Card>>();
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
		}

		[TestMethod]
		public void TestThatCardEntityOfMatchingIDIsReturned()
		{
			//--Arrange	
			this._mock.Setup(m => m.GetByID(1)).Returns(this._card);
			this._repo = this._mock.Object;

			//--Act
			var result = this._getEntityByIDComponent.Execute(this._repo, 1);

			//--Assert
			Assert.AreEqual(1, result.ID);
		}
	}
}
