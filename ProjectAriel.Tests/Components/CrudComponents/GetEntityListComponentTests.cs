using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using Moq;
using System.Collections.Generic;
using ProjectAriel.Enums;
using ProjectAriel.Components.CrudComponents;

namespace ProjectAriel.Tests.Components.CrudComponents
{
	[TestClass]
	public class GetEntityListComponentTests
	{
		private IRepository<Card> _repo;
		private GetEntityListComponent _getEntityListComponent;
		private Mock<IRepository<Card>> _mock;

		[TestInitialize]
		public void Setup()
		{
			this._getEntityListComponent = new GetEntityListComponent();
			this._mock = new Mock<IRepository<Card>>();
		}

		[TestMethod]
		public void TestThatRepositoryReturnsAllCardEntities()
		{
			//--Arrange
			this._mock.Setup(m => m.GetAll()).Returns(new List<Card>
			{
				new Card 
				{ 
					Name = "Bang!", 
					ID = 1, 
					Description = "Kill 'Em All", 
					Suit = Suit.Spade, 
					Rank = Rank.Ace, 
					Cardtype = CardType.Basic, 
					IsActive = true 
				},

				new Card
				{ 
					Name = "Missed!", 
					ID = 2, 
					Description = "Missed me Fool", 
					Suit = Suit.Spade, 
					Rank = Rank.Ace, 
					Cardtype = CardType.Basic, 
					IsActive = true 
				},
				
				new Card 
				{
					Name = "Beer!", 
					ID = 3, 
					Description = "Drink up", 
					Suit = Suit.Spade, 
					Rank = Rank.Ace, 
					Cardtype = CardType.Basic, 
					IsActive = true 
				}
			});
			this._repo = this._mock.Object;

			//--Act
			var result = this._getEntityListComponent.Execute(this._repo);

			//--Assert
			Assert.AreEqual(3, result.Count);
		}
	}
}
