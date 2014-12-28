using BusinessLogic.Components.CrudComponents;
using BusinessLogic.Enums;
using BusinessLogic.Models;
using BusinessLogic.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.BusinessLogic.Components.CrudComponents
{
	[TestClass]
	public class AddEntityComponentTests
	{
		private IRepository<Card> _cardRepo;
		private IRepository<Player> _playerRepo;
		private AddEntityComponent _addEntityComponent;
		private Mock<IRepository<Card>> _cardRepositoryMock;
		private Mock<IRepository<Player>> _playerRepositoryMock;
		private Card _card;
		private Player _player;

		[TestInitialize]
		public void Setup()
		{
			this._addEntityComponent = new AddEntityComponent();
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
		public void TestThatANewCardIsAddedToTheRepository()
		{
			//--Arrange
			this._cardRepositoryMock.Setup(m => m.Add(this._card));
			this._cardRepo = this._cardRepositoryMock.Object;

			//--Act
			this._addEntityComponent.Execute(this._cardRepo, this._card);

			//--Assert
			this._cardRepositoryMock.Verify(m => m.Add(It.Is<Card>(c => c.ID == this._card.ID && c.Name == this._card.Name && c.IsActive == this._card.IsActive)));
		}

		[TestMethod]
		public void TestThatNewPlayerIsAddedToTheRepository()
		{
			//--Arrange
			this._playerRepositoryMock.Setup(m => m.Add(this._player));
			this._playerRepo = this._playerRepositoryMock.Object;

			//--Act
			this._addEntityComponent.Execute(this._playerRepo, this._player);

			//--Assert
			this._playerRepositoryMock.Verify(m => m.Add(It.Is<Player>(p => p.ID == this._player.ID && p.Name == this._player.Name && p.IsActive == this._player.IsActive)));
		}
	}
}
