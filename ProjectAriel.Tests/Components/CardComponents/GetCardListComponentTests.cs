using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using Moq;
using ProjectAriel.Components.CardComponents;
using System.Collections.Generic;

namespace ProjectAriel.Tests.Components.CardComponents
{
	[TestClass]
	public class GetCardListComponentTests
	{
		private IRepository<Card> _repo;
		private GetCardListComponent _getCardListComponent;
		private Mock<IRepository<Card>> _mock;

		[TestInitialize]
		public void Setup()
		{
			this._getCardListComponent = new GetCardListComponent();
			this._mock = new Mock<IRepository<Card>>();
		}

		[TestMethod]
		public void TestThatRepositoryReturnsAllCards()
		{
			//--Arrange
			this._mock.Setup(m => m.GetAll()).Returns(new List<Card>
			{
				new Card { Name = "Bang!", ID = 1, Description = "Kill 'Em All", Suit = 'S', Rank = 'A', Type = "Basic", IsActive = true },
				new Card { Name = "Missed!", ID = 2, Description = "Missed me Fool", Suit = 'S', Rank = 'A', Type = "Basic", IsActive = true },
				new Card { Name = "Beer!", ID = 3, Description = "Drink up", Suit = 'S', Rank = 'A', Type = "Basic", IsActive = true }
			});
			this._repo = this._mock.Object;

			//--Act
			var result = this._getCardListComponent.Execute(this._repo);

			//--Assert
			Assert.AreEqual(3, result.Count);
		}
	}
}
