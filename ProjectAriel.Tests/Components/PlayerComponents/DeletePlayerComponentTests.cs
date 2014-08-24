using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Repositories;
using ProjectAriel.Models;
using ProjectAriel.Components.PlayerComponents;
using Moq;

namespace ProjectAriel.Tests.Components.PlayerComponents
{
	[TestClass]
	public class DeletePlayerComponentTests
	{
		private IRepository<Player> _repo;
		private DeletePlayerComponent _deletePlayerComponent;
		private Mock<IRepository<Player>> _mock;
		private Player _player;

		[TestInitialize]
		public void Setup()
		{
			this._deletePlayerComponent = new DeletePlayerComponent();
			this._mock = new Mock<IRepository<Player>>();
			this._player = new Player { ID = 1, Name = "Smitty Werbenjagermanjensen", IsActive = true };
		}

		[TestMethod]
		public void TestThatPlayerBecomesInactive()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._player));
			this._repo = this._mock.Object;

			//--Act
			this._deletePlayerComponent.Execute(this._repo, this._player.ID);
			var result = this._repo.GetByID(this._player.ID);

			//--Assert
			Assert.IsNull(result);
		}
	}
}
