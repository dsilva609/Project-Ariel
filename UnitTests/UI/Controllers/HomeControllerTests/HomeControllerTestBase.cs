using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UI.Controllers;

namespace UnitTests.UI.Controllers.HomeControllerTests
{
	[TestClass]
	public class HomeControllerTestBase
	{
		protected Mock<HomeController> homeControllerMock;

		[TestInitialize]
		public void Setup()
		{
			homeControllerMock = new Mock<HomeController>();
		}
	}
}