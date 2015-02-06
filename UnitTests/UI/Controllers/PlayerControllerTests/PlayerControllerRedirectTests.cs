using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace UnitTests.UI.Controllers.PlayerControllerTests
{
	[TestClass]
	public class PlayerControllerRedirectTests : PlayerControllerTestBase
	{
		[TestInitialize]
		public override void Setup()
		{
			base.Setup();

			var controllerContext = new Mock<ControllerContext>();
			var principal = new Mock<IPrincipal>();
			principal.Setup(p => p.IsInRole("Admin")).Returns(true);
			principal.SetupGet(x => x.Identity.Name).Returns("asdf");
			principal.SetupGet(x => x.Identity.IsAuthenticated).Returns(true);
			controllerContext.SetupGet(x => x.HttpContext.User).Returns(principal.Object);
			//controller.ControllerContext = controllerContext.Object;

			base._playerController.Object.ControllerContext = controllerContext.Object;

			base._playerController.Setup(mock => mock.RedirectUser()).Returns(new ViewResult { ViewName = base._playerController.Object.User.IsInRole("Admin") ? MVC.Player.Views.Edit : MVC.Player.Views.Details });
		}

		[TestMethod]
		public void ThatRedirectWhenUserIsAdminRedirectsToEditPage()
		{
			//--Act
			var result = base._playerController.Object.RedirectUser() as ViewResult;

			//--Assert
			Assert.AreEqual(MVC.Player.Views.Edit, result.ViewName);
		}
	}
}