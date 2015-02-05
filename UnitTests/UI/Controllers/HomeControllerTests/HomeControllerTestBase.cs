using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
using NUnit.Framework;
using UI.Controllers;


namespace UnitTests.UI.Controllers.HomeControllerTests
{
	[TestClass]
	public class HomeControllerTestBase
	{
		protected HomeController homeControllerMock;

		[SetUp]
		public virtual void Setup()
		{
			homeControllerMock = new HomeController();
		}
	}
}
