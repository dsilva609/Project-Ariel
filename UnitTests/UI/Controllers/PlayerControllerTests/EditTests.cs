using BusinessLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Mvc;

namespace UnitTests.UI.Controllers.PlayerControllerTests
{
	[TestClass]
	public class EditTests : PlayerControllerTestBase
	{
		private Player _expectedEditPlayerModel;
		private Player _expectedDefaultPlayerModel;

		[TestInitialize]
		public override void Setup()
		{
			base.Setup();

			this._expectedEditPlayerModel = new Player
			{
				ID = 1,
				Name = "Smitty Werbenjagermanjensen"
			};

			this._expectedDefaultPlayerModel = new Player();
		}

		[TestMethod]
		public void ThatEditActionReturnsAView()
		{
			//--Arrange
			base._playerController.Setup(mock => mock.Edit()).Returns(new ViewResult { ViewName = MVC.Player.Views.Edit });

			//--Act
			var result = base._playerController.Object.Edit() as ViewResult;

			//--Assert
			Assert.AreEqual(MVC.Player.Views.Edit, result.ViewName);
		}

		[TestMethod]
		public void ThatSpecifiedDefaultViewModelIsSentToView()
		{
			//--Arrange
			base._playerController.Setup(mock => mock.Edit(It.IsNotNull<int>())).Returns(new ViewResult { ViewData = new ViewDataDictionary(this._expectedDefaultPlayerModel) });

			//--Act
			var result = base._playerController.Object.Edit(It.IsNotNull<int>()) as ViewResult;

			//--Assert
			Assert.AreEqual(this._expectedDefaultPlayerModel, result.ViewData.Model);
		}

		[TestMethod]
		public void ThatSpecifiedPopulatedViewModelIsSentToView()
		{
			//--Arrange
			base._playerController.Setup(mock => mock.Edit(It.IsAny<int>())).Returns(new ViewResult { ViewData = new ViewDataDictionary(this._expectedEditPlayerModel) });

			//--Act
			var result = base._playerController.Object.Edit(1) as ViewResult;

			//--Assert
			Assert.AreEqual(this._expectedEditPlayerModel, result.ViewData.Model);
		}
	}
}