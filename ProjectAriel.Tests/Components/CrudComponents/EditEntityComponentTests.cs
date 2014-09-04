using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectAriel.Components.CrudComponents;
using ProjectAriel.Enums;
using ProjectAriel.Models;
using ProjectAriel.Repositories;

namespace ProjectAriel.Tests.Components.CrudComponents
{
	[TestClass]
	public class EditEntityComponentTests
	{
		private IRepository<Card> _repo;
		private EditEntityComponent _editEntityComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._editEntityComponent = new EditEntityComponent();
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
		public void TestThatCardEntityNameIsChanged()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._card));
			this._repo = this._mock.Object;
			this._card.Name = "Indians!";

			//--Act
			this._editEntityComponent.Execute(this._repo, this._card);

			//--Assert
			this._mock.Verify(m => m.Edit(It.Is<Card>(c => c.Name == "Indians!")));
		}
	}
}
