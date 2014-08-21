using System;
using ProjectAriel.Repositories;
using ProjectAriel.Models;
using ProjectAriel.Components.PlayerComponents;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectAriel.Tests.Components.PlayerComponents
{
	[TestClass]
	public class GetPlayerByIDComponentTests
	{
		private IRepository<Player> _repo;
		private GetPlayerByIDComponent _getPlayerByIDComponent;
		private Mock<IRepository<Player>> _mock;

		[TestInitialize]
		public void Setup()
		{
			this._mock = new Mock<IRepository<Player>>();
			this._getPlayerByIDComponent = new GetPlayerByIDComponent();
		}

		[TestMethod]
		public void TestThatPlayerOfMatchingIDIsReturned()
		{
			//--Arrange	
			this._mock.Setup(m => m.GetByID(1)).Returns(new Player { ID = 1, Name = "Smitty Werbenjagermanjensen", IsActive = true });
			this._repo = this._mock.Object;

			//--Act
			var result = this._getPlayerByIDComponent.Execute(this._repo, 1);

			//--Assert
			Assert.AreEqual(result.ID, 1);
		}
	}
}
