using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafetoTest;


namespace CafetoUnitTest
{
    [TestClass]
    public class JobLoggerTest
    {
        private const string TestMessage = "Test Message";
        private const string WarningMessage = "Test Warning";
        private const string ErrorMessage = "Test Error";
        [TestMethod]
        public void TestMethod1()
        {
            //var jobLogger = new JobLogger(true, true, true, true, true);
            //JobLogger.LogMessage(TestMessage, true, false, false);
            //JobLogger.LogMessage(WarningMessage, false, true, false);
            //JobLogger.LogMessage(ErrorMessage, false, false, true);
            
            var jobLogger = new JobLogger(); // JobLogger().setConsole(true).setFileText(true);
            JobLogger.LogMessage(TestMessage);
            JobLogger.LogWarning(WarningMessage);
            JobLogger.LogError(ErrorMessage);

            var jobLogger2 = new JobLogger().setConsole(false).setFileText(true);
            JobLogger.LogMessage(TestMessage);
            JobLogger.LogWarning(WarningMessage);
            JobLogger.LogError(ErrorMessage);

            var jobLogger3 = new JobLogger().setConsole(true).setFileText(false);
            JobLogger.LogMessage(TestMessage);
            JobLogger.LogWarning(WarningMessage);
            JobLogger.LogError(ErrorMessage);

            var jobLogger4 = new JobLogger().setConsole(false).setFileText(false);
            JobLogger.LogMessage(TestMessage);
            JobLogger.LogWarning(WarningMessage);
            JobLogger.LogError(ErrorMessage);
        }
    }
}
