using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UI.Controllers;

namespace UnitTests.UI.Controllers.CardControllerTests
{
	[TestClass]
	public class CardControllerTestBase
	{
		protected Mock<CardController> _cardController;

		[TestInitialize]
		public virtual void Setup()
		{
			this._cardController = new Mock<CardController>();
		}
	}
}