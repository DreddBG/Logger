using LoggerLib.Contracts;

namespace LoggerLib.Models
{
    public class Logger : ILogger
    {
        private IAppender appender;

        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        private void Log(string TimeStamp, string Message, ReportLevel level)
        {
            this.appender.WriteLine(new Log(TimeStamp, Message, level));
        }

        public void Info(string TimeStamp, string Message)
        {
            var protectLevel = ReportLevel.Info;

            Log(TimeStamp, Message, protectLevel);
        }

        public void Warning(string TimeStamp, string Message)
        {
            var protectLevel = ReportLevel.Warning;

            Log(TimeStamp, Message, protectLevel);
        }

        public void Error(string TimeStamp, string Message)
        {
            var protectLevel = ReportLevel.Error;

            Log(TimeStamp, Message, protectLevel);
        }

        public void Critical(string TimeStamp, string Message)
        {
            var protectLevel = ReportLevel.Critical;

            Log(TimeStamp, Message, protectLevel);
        }

        public void Fatal(string TimeStamp, string Message)
        {
            var protectLevel = ReportLevel.Fatal;

            Log(TimeStamp, Message, protectLevel);
        }
    }
}
