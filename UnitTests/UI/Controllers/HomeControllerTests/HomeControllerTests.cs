using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace UnitTests.UI.Controllers.HomeControllerTests
{
	[TestClass]
	public class HomeControllerTests : HomeControllerTestBase
	{
		[TestMethod]
		public void ThatIndexActionReturnsAView()
		{
			//--Arrange
			base.Setup();
			base.homeControllerMock.Setup(mock => mock.Index()).Returns(new ViewResult { ViewName = MVC.Home.Views.Index });

			//--Act
			var result = base.homeControllerMock.Object.Index() as ViewResult;

			// Assert
			Assert.AreEqual(MVC.Home.Views.Index, result.ViewName);
		}

		[TestMethod]
		public void ThatAboutActionReturnsAView()
		{
			//--Arrange
			base.Setup();
			base.homeControllerMock.Setup(mock => mock.About()).Returns(new ViewResult { ViewName = MVC.Home.Views.About });

			//--Act
			var result = base.homeControllerMock.Object.About() as ViewResult;

			//--Assert
			Assert.AreEqual(MVC.Home.Views.About, result.ViewName);
		}

		[TestMethod]
		public void ThatContactActionReturnsAView()
		{
			// Arrange
			base.Setup();
			base.homeControllerMock.Setup(mock => mock.Contact()).Returns(new ViewResult { ViewName = MVC.Home.Views.Contact });

			//--Act
			var result = base.homeControllerMock.Object.Contact() as ViewResult;

			//--Assert
			Assert.AreEqual(MVC.Home.Views.Contact, result.ViewName);
		}
	}
}