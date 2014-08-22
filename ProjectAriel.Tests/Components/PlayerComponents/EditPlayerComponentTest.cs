using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Repositories;
using ProjectAriel.Models;
using ProjectAriel.Components.PlayerComponents;
using Moq;

namespace ProjectAriel.Tests.Components.PlayerComponents
{
	[TestClass]
	public class EditPlayerComponentTest
	{
		private IRepository<Player> _repo;
		private EditPlayerComponent _editPlayerComponent;
		private Mock<IRepository<Player>> _mock;
		private Player _player;

		[TestInitialize]
		public void Setup()
		{
			this._editPlayerComponent = new EditPlayerComponent();
			this._mock = new Mock<IRepository<Player>>();
			this._player = new Player { ID = 1, Name = "Smitty Werbenjagermanjensen", IsActive = true };
		}

		[TestMethod]
		public void TestThatPlayerNameIsChanged()
		{
			//--Arrange
			this._mock.Setup(m => m.Add(this._player));
			this._repo = this._mock.Object;
			this._player.Name = "Liam Neeson";

			//--Act
			this._editPlayerComponent.Execute(this._repo, this._player);

			//--Assert
			this._mock.Verify(m => m.Edit(It.Is<Player>(p => p.Name == "Liam Neeson")));
		}
	}
}
