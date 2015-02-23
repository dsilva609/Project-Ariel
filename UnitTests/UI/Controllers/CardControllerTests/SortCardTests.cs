using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;

namespace UnitTests.UI.Controllers.CardControllerTests
{
	[TestClass]
	public class SortCardTests : CardControllerTestBase
	{
		[TestInitialize]
		public override void Setup()
		{
			base.Setup();
		}

		[TestMethod]
		public void ThatSortPlayerActionReturnsAView()
		{
			//--Arrange
			base._cardController.Setup(mock => mock.SortPlayers(It.IsNotNull<string>())).Returns(new ViewResult { ViewName = MVC.Card.Views.Index });

			//--Act
			var result = base._cardController.Object.SortPlayers("apple") as ViewResult;

			//--Assert
			Assert.AreEqual(MVC.Card.Views.Index, result.ViewName);
		}
	}
}