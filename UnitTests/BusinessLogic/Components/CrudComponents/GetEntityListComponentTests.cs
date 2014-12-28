using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using UI.Models;
using BusinessLogic.Repositories;
using BusinessLogic.Models;
using BusinessLogic.Components.CrudComponents;
using BusinessLogic.Enums;

namespace UnitTests.BusinessLogic.Components.CrudComponents
{
	[TestClass]
	public class GetEntityListComponentTests
	{
		private IRepository<Card> _cardRepo;
		private IRepository<Player> _playerRepo;
		private GetEntityListComponent _getEntityListComponent;
		private Mock<IRepository<Card>> _cardRepositoryMock;
		private Mock<IRepository<Player>> _playerRepositoryMock;

		[TestInitialize]
		public void Setup()
		{
			this._getEntityListComponent = new GetEntityListComponent();
			this._cardRepositoryMock = new Mock<IRepository<Card>>();
			this._playerRepositoryMock = new Mock<IRepository<Player>>();
		}

		[TestMethod]
		public void TestThatRepositoryReturnsAllCards()
		{
			//--Arrange
			this._cardRepositoryMock.Setup(m => m.GetAll()).Returns(new List<Card>
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
			this._cardRepo = this._cardRepositoryMock.Object;

			//--Act
			var result = this._getEntityListComponent.Execute(this._cardRepo);

			//--Assert
			Assert.AreEqual(3, result.Count);
		}

		[TestMethod]
		public void TestThatRepositoryReturnsAllPlayers()
		{
			//--Arrange
			this._playerRepositoryMock.Setup(m => m.GetAll()).Returns(new List<Player> { 
				new Player 
				{ 
					ID = 1, 
					Name = "Smitty Werbenjagermanjensen", 
					IsActive = true 
				},
 
				new Player 
				{ 
					Name = "Walter White", 
					ID = 2, 
					IsActive = true 
				},
 
				new Player 
				{ 
					Name = "Tom Neville", 
					ID = 3, 
					IsActive = true 
				}
			});
			this._playerRepo = this._playerRepositoryMock.Object;

			//--Act
			var result = this._getEntityListComponent.Execute(this._playerRepo);

			//--Assert
			Assert.AreEqual(3, result.Count);
		}
	}
}
