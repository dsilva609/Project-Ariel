using BusinessLogic.Components.CrudComponents;
using BusinessLogic.Enums;
using BusinessLogic.Models;
using BusinessLogic.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.BusinessLogic.Components.CrudComponents
{
	[TestClass]
	public class DeleteEntityComponentTests
	{
		private IRepository<Card> _cardRepo;
		private IRepository<Player> _playerRepo;
		private DeleteEntityComponent _deleteEntityComponent;
		private Mock<IRepository<Card>> _cardRepositoryMock;
		private Mock<IRepository<Player>> _playerRepositoryMock;
		private Card _card;
		private Player _player;

		[TestInitialize]
		public void Setup()
		{
			this._deleteEntityComponent = new DeleteEntityComponent();
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
		public void TestThatCardIsRemovedFromTheRepository()
		{
			//--Arrange
			this._cardRepositoryMock.Setup(m => m.Add(this._card));
			this._cardRepo = this._cardRepositoryMock.Object;

			//--Act
			this._deleteEntityComponent.Execute(this._cardRepo, this._card.ID);
			var result = this._cardRepo.GetByID(this._card.ID);

			//--Assert
			Assert.IsNull(result);
		}

		[TestMethod]
		public void TestThatPlayerIsRemovedFromTheRepository()
		{
			//--Arrange
			this._playerRepositoryMock.Setup(m => m.Add(this._player));
			this._playerRepo = this._playerRepositoryMock.Object;

			//--Act
			this._deleteEntityComponent.Execute(this._playerRepo, this._player.ID);
			var result = this._playerRepo.GetByID(this._player.ID);

			//--Assert
			Assert.IsNull(result);
		}
	}
}
