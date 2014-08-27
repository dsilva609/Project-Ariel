using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using Moq;
using ProjectAriel.Components.CardComponents;

namespace ProjectAriel.Tests.Components.CardComponents
{
	[TestClass]
	public class DeleteCardComponentTests
	{
		private IRepository<Card> _repo;
		private DeleteCardComponent _deleteCardComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._deleteCardComponent = new DeleteCardComponent();
			this._mock = new Mock<IRepository<Card>>();
			this._card = new Card { Name = "Bang!", ID = 1, Description = "Kill 'Em All", Suit = 'S', Rank = 'A', Type = "Basic", IsActive = true };
		}

		[TestMethod]
		public void TestThatCardIsRemovedFromTheRepository()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._card));
			this._repo = this._mock.Object;

			//--Act
			this._deleteCardComponent.Execute(this._repo, this._card.ID);
			var result = this._repo.GetByID(this._card.ID);

			//--Assert
			Assert.IsNull(result);
		}
	}
}
