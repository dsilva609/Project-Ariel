using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace UnitTests.UI.Controllers.HomeControllerTests
{
	[TestClass]
	public class HomeControllerTests : HomeControllerTestBase
	{
		[TestMethod]
		public void Index()
		{
			//--Arrange
			base.Setup();

			//--Act
			var result = base.homeControllerMock.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void About()
		{
			//--Arrange
			base.Setup();

			//--Act
			var result = base.homeControllerMock.About() as ViewResult;

			//--Assert
			Assert.AreEqual("Your application description page.", result.ViewBag.Message);
		}

		[TestMethod]
		public void Contact()
		{
			// Arrange
			base.Setup();

			//--Act
			var result = base.homeControllerMock.Contact() as ViewResult;

			//--Assert
			Assert.IsNotNull(result);
		}
	}
}
