using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Principal;
using System.Web.Mvc;

namespace UnitTests.UI.Controllers
{
	[TestClass]
	public class ControllerTestBase
	{
		public virtual Mock<ControllerContext> SetupAuthorization(string userRole, bool userIsOfRole, bool userIsAuthenticated)
		{
			var controllerContext = new Mock<ControllerContext>();
			var principal = new Mock<IPrincipal>();
			principal.Setup(p => p.IsInRole(userRole)).Returns(userIsOfRole);
			principal.SetupGet(x => x.Identity.IsAuthenticated).Returns(userIsAuthenticated);
			controllerContext.SetupGet(x => x.HttpContext.User).Returns(principal.Object);

			return controllerContext;
		}
	}
}