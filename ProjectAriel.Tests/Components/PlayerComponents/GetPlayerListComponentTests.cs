using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectAriel.Repositories;
using ProjectAriel.Models;
using Moq;
using ProjectAriel.Components.PlayerComponents;
using System.Collections.Generic;

namespace ProjectAriel.Tests.Components.PlayerComponents
{
	[TestClass]
	public class GetPlayerListComponentTests
	{
		private IRepository<Player> _repo;
		private GetPlayerListComponent _getPlayerListComponent;
		private Mock<IRepository<Player>> _mock;

		[TestInitialize]
		public void Setup()
		{
			this._getPlayerListComponent = new GetPlayerListComponent();
			this._mock = new Mock<IRepository<Player>>();
		}
		
		[TestMethod]
		public void TestThatRepositoryReturnsAllPlayers()
		{
			//--Arrange
			this._mock.Setup(m => m.GetAll()).Returns( new List<Player> { 
				new Player { ID = 1, Name = "Smitty Werbenjagermanjensen", IsActive = true }, 
				new Player { Name = "Walter White", ID = 2, IsActive = true }, 
				new Player { Name = "Tom Neville", ID = 3, IsActive = true}});
			this._repo = this._mock.Object;

			//--Act
			var result = this._getPlayerListComponent.Execute(this._repo);

			//--Assert
			Assert.AreEqual(result.Count, 3);
		}
	}
}
