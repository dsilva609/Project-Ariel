using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectAriel.Components.CrudComponents;
using ProjectAriel.Enums;
using ProjectAriel.Models;
using ProjectAriel.Repositories;

namespace ProjectAriel.Tests.Components.CrudComponents
{
	[TestClass]
	public class DeleteEntityComponentTests
	{
		private IRepository<Card> _repo;
		private DeleteEntityComponent _deleteEntityComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._deleteEntityComponent = new DeleteEntityComponent();
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
		public void TestThatCardEntityIsRemovedFromTheRepository()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._card));
			this._repo = this._mock.Object;

			//--Act
			this._deleteEntityComponent.Execute(this._repo, this._card.ID);
			var result = this._repo.GetByID(this._card.ID);

			//--Assert
			Assert.IsNull(result);
		}
	}
}
