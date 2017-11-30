using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDemo;

namespace TestDemo
{
	[TestClass]
	public class HelloTest
	{
		private Hello _hello = new Hello();

		[TestMethod]
		public void Hello_OnNameReceived_ShouldReturnMessageSayingHello()
		{
			var msg = _hello.GetMessage("fml");
			Assert.AreEqual("Hello fml", msg);
		}

		[TestMethod]
		public void Hello_OnNull_ShouldReturnMessageSayingHello()
		{
			var msg = _hello.GetMessage(null);
			Assert.AreEqual("Hello null", msg);
		}
	}
}
