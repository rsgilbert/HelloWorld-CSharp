

namespace HelloWorld.Tests
{
    [TestClass]
    public class WhenProgramRuns
    {
        private string _consoleOutput;

        [TestInitialize]
        public void Initialize()
        {
            var w = new StringWriter();
            Console.SetOut(w);
            Program.Main(new string[0]);
            _consoleOutput = w.GetStringBuilder().ToString().Trim();

        }


        [TestMethod]
        public void SayHelloWorld()
        {
            Assert.AreEqual("hello, world", _consoleOutput);
        }
    }

}