using CafetoTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CafetoTestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string TestMessage = "Test Message";
        private const string WarningMessage = "Test Warning";
        private const string ErrorMessage = "Test Error";
        [TestMethod]
        public void JobLoggerBasicTest()
        {
            var jobLogger1 = new JobLogger().SetConsole(false).SetFileText(true);
            JobLogger.LogMessage(TestMessage + " only text file");
            JobLogger.LogWarning(WarningMessage + " only text file");
            JobLogger.LogError(ErrorMessage + " only text file");

            var jobLogger2 = new JobLogger().SetConsole(true).SetFileText(false);
            JobLogger.LogMessage(TestMessage + " only console");
            JobLogger.LogWarning(WarningMessage + " only console");
            JobLogger.LogError(ErrorMessage + " only console");

            var jobLogger3 = new JobLogger().SetConsole(true).SetFileText(true);
            JobLogger.LogMessage(TestMessage + " console and Text file");
            JobLogger.LogWarning(WarningMessage + " console and Text file");
            JobLogger.LogError(ErrorMessage + " console and Text file");

            var jobLogger4 = new JobLogger().SetConsole(false).SetFileText(false);
            JobLogger.LogMessage(TestMessage);
            JobLogger.LogWarning(WarningMessage);
            JobLogger.LogError(ErrorMessage);
        }
    }
}
