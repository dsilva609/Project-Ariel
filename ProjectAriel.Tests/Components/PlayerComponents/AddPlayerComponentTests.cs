using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Models;
using ProjectAriel.Repositories;
using ProjectAriel.Components.PlayerComponents;
using Moq;

namespace ProjectAriel.Tests.Components.PlayerComponents
{
	[TestClass]
	public class AddPlayerComponentTests
	{
		private IRepository<Player> _repo;
		private AddPlayerComponent _addPlayerComponent;
		private Mock<IRepository<Player>> _mock;
		private Player _player;

		[TestInitialize]
		public void Setup()
		{
			this._addPlayerComponent = new AddPlayerComponent();
			this._player = new Player { ID = 1, Name = "Smitty Werbenjagermanjensen", IsActive = true };
			this._mock = new Mock<IRepository<Player>>();

		}

		[TestMethod]
		public void TestThatNewPlayerIsAddedToTheRepository()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._player));
			this._repo = this._mock.Object;

			//--Act
			this._addPlayerComponent.Execute(this._repo, this._player);

			//--Assert
			this._mock.Verify(m => m.Add(It.Is<Player>(p => p.ID == this._player.ID && p.Name == this._player.Name && p.IsActive == this._player.IsActive )));
		}
	}
}
