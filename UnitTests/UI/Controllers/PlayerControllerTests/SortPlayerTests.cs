using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;

namespace UnitTests.UI.Controllers.PlayerControllerTests
{
	[TestClass]
	public class SortPlayerTests : PlayerControllerTestBase
	{
		[TestMethod]
		public void ThatSortPlayerActionReturnsAView()
		{
			//--Arrange
			base._playerController.Setup(mock => mock.SortPlayers(It.IsNotNull<string>())).Returns(new ViewResult { ViewName = MVC.Player.Views.Index });

			//--Act
			var result = base._playerController.Object.SortPlayers("Newman") as ViewResult;

			//--Assert
			Assert.AreEqual(MVC.Player.Views.Index, result.ViewName);
		}
	}
}