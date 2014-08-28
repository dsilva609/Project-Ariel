using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Models;
using Moq;
using ProjectAriel.Repositories;
using ProjectAriel.Components.CardComponents;

namespace ProjectAriel.Tests.Components.CardComponents
{
	[TestClass]
	public class EditCardComponentTests
	{
		private IRepository<Card> _repo;
		private EditCardComponent _editCardComponent;
		private Mock<IRepository<Card>> _mock;
		private Card _card;

		[TestInitialize]
		public void Setup()
		{
			this._editCardComponent = new EditCardComponent();
			this._mock = new Mock<IRepository<Card>>();
			this._card = new Card { Name = "Bang!", ID = 1, Description = "Kill 'Em All", Suit = 'S', Rank = 'A', Type = "Basic", IsActive = true };
		}

		[TestMethod]
		public void TestThatCardNameIsChanged()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._card));
			this._repo = this._mock.Object;
			this._card.Name = "Indians!";

			//--Act
			this._editCardComponent.Execute(this._repo, this._card);

			//--Assert
			this._mock.Verify(m => m.Edit(It.Is<Card>(c => c.Name == "Indians!")));
		}
	}
}
