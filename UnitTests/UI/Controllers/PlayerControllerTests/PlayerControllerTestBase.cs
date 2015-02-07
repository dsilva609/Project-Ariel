using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UI.Controllers;

namespace UnitTests.UI.Controllers.PlayerControllerTests
{
	[TestClass]
	public class PlayerControllerTestBase
	{
		protected Mock<PlayerController> _playerController;
		protected ControllerTestBase _controllerTestBase;

		[TestInitialize]
		public virtual void Setup()
		{
			this._playerController = new Mock<PlayerController>();
			this._controllerTestBase = new ControllerTestBase();
		}
	}
}