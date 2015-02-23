using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UI.Controllers;

namespace UnitTests.UI.Controllers.CardControllerTests
{
	[TestClass]
	public class CardControllerTestBase
	{
		protected Mock<CardController> _cardController;
		protected ControllerTestBase _controllerTestBase;
		//protected Mock<ControllerContext> _context;
		//protected MockHttpSession _session;

		[TestInitialize]
		public virtual void Setup()
		{
			this._cardController = new Mock<CardController>();
			this._controllerTestBase = new ControllerTestBase();

			this._cardController.Object.ControllerContext = this._controllerTestBase.SetupSession().Object;
		}
	}
}