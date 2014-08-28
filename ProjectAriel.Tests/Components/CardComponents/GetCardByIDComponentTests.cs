using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using Moq;
using ProjectAriel.Components.CardComponents;

namespace ProjectAriel.Tests.Components.CardComponents
{
	[TestClass]
	public class GetCardByIDComponentTests
	{
		private IRepository<Card> _repo;
		private GetCardByIDComponent _getCardByIDComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._getCardByIDComponent = new GetCardByIDComponent();
			this._mock = new Mock<IRepository<Card>>();
			this._card = new Card { Name = "Bang!", ID = 1, Description = "Kill 'Em All", Suit = 'S', Rank = 'A', Type = "Basic", IsActive = true };
		}

		[TestMethod]
		public void TestThatCardOfMatchingIDIsReturned()
		{
			//--Arrange	
			this._mock.Setup(m => m.GetByID(1)).Returns(this._card);
			this._repo = this._mock.Object;

			//--Act
			var result = this._getCardByIDComponent.Execute(this._repo, 1);

			//--Assert
			Assert.AreEqual(1, result.ID);
		}
	}
}
