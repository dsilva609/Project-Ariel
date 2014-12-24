using BusinessLogic.Components.CrudComponents;
using BusinessLogic.Enums;
using BusinessLogic.Models;
using BusinessLogic.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UI.Tests.Components.CrudComponents
{
	[TestClass]
	public class EditEntityComponentTests
	{
		private IRepository<Card> _cardRepo;
		private IRepository<Player> _playerRepo;
		private EditEntityComponent _editEntityComponent;
		private Mock<IRepository<Card>> _cardRepositoryMock;
		private Mock<IRepository<Player>> _playerRepositoryMock;
		private Card _card;
		private Player _player;

		[TestInitialize]
		public void Setup()
		{
			this._editEntityComponent = new EditEntityComponent();
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
		public void TestThatCardNameIsChanged()
		{
			//--Arrange
			this._cardRepositoryMock.Setup(m => m.Add(this._card));
			this._cardRepo = this._cardRepositoryMock.Object;
			this._card.Name = "Indians!";

			//--Act
			this._editEntityComponent.Execute(this._cardRepo, this._card);

			//--Assert
			this._cardRepositoryMock.Verify(m => m.Edit(It.Is<Card>(c => c.Name == "Indians!")));
		}


		[TestMethod]
		public void TestThatPlayerNameIsChanged()
		{
			//--Arrange
			this._playerRepositoryMock.Setup(m => m.Add(this._player));
			this._playerRepo = this._playerRepositoryMock.Object;
			this._player.Name = "Liam Neeson";

			//--Act
			this._editEntityComponent.Execute(this._playerRepo, this._player);

			//--Assert
			this._playerRepositoryMock.Verify(m => m.Edit(It.Is<Player>(p => p.Name == "Liam Neeson")));
		}
	}
}
