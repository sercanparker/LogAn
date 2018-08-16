using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{

    [TestFixture]
    public class LogAnalyzerParameterizedTests
    {
        public LogAnalyzerParameterizedTests()
        {
        }

		[TestCase("filegoodextension.slf")]
		[TestCase("filegoodextension.SLF")]
        //more generic method name
        //includes only positive tests.
		public void IsValidLogFileName_ValidExtension_ReturnsTrue(string fileName)
		{
			LogAnalyzer analyzer = new LogAnalyzer();

			bool result = analyzer.IsValidLogFileName(fileName);

			Assert.IsTrue(result);
		}


		[TestCase("filegoodextension.slf",true)]
        [TestCase("filegoodextension.SLF",true)]
		[TestCase("filebadextesion.pdf", false)]
		public void IsValidLogFileName_VariousExtensions_ChecksThem(string fileName, bool expected)
		{
			LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(fileName);

			Assert.AreEqual(expected, result);         
		}


        [Test]
        //exception assertion was changed with NUnit 3.0
		//ref : https://stackoverflow.com/questions/33895457/expectedexception-in-nunit-gave-me-an-error
		public void IsValidLogFile_EmptyFileName_ThrowException()
		{
			LogAnalyzer analyzer = new LogAnalyzer();

			Assert.That(() => analyzer.IsValidLogFileName(String.Empty), Throws.TypeOf<ArgumentException>());         
		}

        [Test]
        //to ensure type of thrown exception, use catch method in Assert class.
        //thanks to Assert.Catch method, tests bugs could be solved.
		public void IsValidLogFile_EmptyFileName_CatchException()
		{
			LogAnalyzer analyzer = new LogAnalyzer();

			var exception = Assert.Catch(() => analyzer.IsValidLogFileName(String.Empty));

			StringAssert.Contains("filename should not be empty or null.", exception.Message);
            
		}
    }
}
