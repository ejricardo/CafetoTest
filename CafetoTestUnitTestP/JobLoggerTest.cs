using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafetoTest;

namespace CafetoTestUnitTest
{
    [TestClass]
    public class JobLoggerTest
    {
        private const string TestMessage = "Test Message";
        private const string WarningMessage = "Test Warning";
        private const string ErrorMessage = "Test Error";
        JobLoggerTest _a;
        JobLogger _b;
        [TestMethod]
        public void TestMethod1()
        {
            
            var jobLogger1 = new JobLogger().SetConsole(false).SetFileText(true);
            JobLogger.LogMessage(TestMessage + " only text file");
            JobLogger.LogWarning(WarningMessage + " only text file");
            JobLogger.LogError(ErrorMessage + " only text file");
        }
    }
}
