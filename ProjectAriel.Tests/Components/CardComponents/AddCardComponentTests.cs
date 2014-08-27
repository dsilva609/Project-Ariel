using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectAriel.Components.CardComponents;
using ProjectAriel.Models;
using ProjectAriel.Repositories;

namespace ProjectAriel.Tests.Components.CardComponents
{
	[TestClass]
	public class AddCardComponentTests
	{
		private readonly IRepository<Card> _repo;
		private AddCardComponent _addCardComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._addCardComponent = new AddCardComponent();
			this._card = new Card { Name = "Bang!", ID = 1, Description = "Kill 'Em All", Suit = 'S', Rank = 'A', Type = "Basic", IsActive = true };
			this._mock = new Mock<IRepository<Card>>();
		}

		[TestMethod]
		public void TestThatANewCardIsAddedToTheDatabase()
		{
			//--Arrange

			//--Act

			//--Assert
			Assert.AreEqual(0, 1);
		}
	}
}
