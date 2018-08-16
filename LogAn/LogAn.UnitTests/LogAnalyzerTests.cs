using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{

    /*
        Class naming standart is [ClassName]Tests.
    */
    [TestFixture] //denotes a class that holds automated NUnit tests.
    public class LogAnalyzerTests
    {
        public LogAnalyzerTests()
        {
        }

        /*
            method naming standart is [UnitOfWorkName]_[ScenarioUnderTest]_[ExpectedBehavior].
        */
        [Test] //donotes a test method in LogAnalyzerTests class.
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {

            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("example.bar");

            Assert.IsFalse(result);

        }

        [Test]
		public void IsValidLogFileName_GoodExtensitonLowerCase_ReturnsTrue()
		{
			LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filegoodextension.slf");

            Assert.IsTrue(result);


		}

        [Test]
		public void IsValidLogFileName_GoodExtensionUpperCase_ReturnsTrue()
		{
			LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("filegoodextension.SLF");

            Assert.IsTrue(result);



		}



    }
}
