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
		private IRepository<Card> _cardRepo;
		private IRepository<Player> _playerRepo;
		private GetEntityByIDComponent _getEntityByIDComponent;
		private Mock<IRepository<Card>> _cardRepositoryMock;
		private Mock<IRepository<Player>> _playerRepositoryMock;
		private Card _card;
		private Player _player;

		[TestInitialize]
		public void Setup()
		{
			this._getEntityByIDComponent = new GetEntityByIDComponent();
			this._cardRepositoryMock = new Mock<IRepository<Card>>();
			this._playerRepositoryMock = new Mock<IRepository<Player>>();

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

			this._player = new Player
			{
				ID = 1,
				Name = "Smitty Werbenjagermanjensen",
				IsActive = true
			};
		}

		[TestMethod]
		public void TestThatCardOfMatchingIDIsReturned()
		{
			//--Arrange	
			this._cardRepositoryMock.Setup(m => m.GetByID(1)).Returns(this._card);
			this._cardRepo = this._cardRepositoryMock.Object;

			//--Act
			var result = this._getEntityByIDComponent.Execute(this._cardRepo, 1);

			//--Assert
			Assert.AreEqual(1, result.ID);
		}


		[TestMethod]
		public void TestThatPlayerOfMatchingIDIsReturned()
		{
			//--Arrange	
			this._playerRepositoryMock.Setup(m => m.GetByID(1)).Returns(this._player);
			this._playerRepo = this._playerRepositoryMock.Object;

			//--Act
			var result = this._getEntityByIDComponent.Execute(this._playerRepo, 1);

			//--Assert
			Assert.AreEqual(1, result.ID);
		}
	}
}
