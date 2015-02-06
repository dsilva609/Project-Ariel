using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Principal;
using UI.Controllers;

namespace UnitTests.UI.Controllers.PlayerControllerTests
{
	[TestClass]
	public class PlayerControllerTestBase
	{
		protected Mock<PlayerController> _playerController;

		[TestInitialize]
		public virtual void Setup()
		{
			this._playerController = new Mock<PlayerController>();
		}
	}
}