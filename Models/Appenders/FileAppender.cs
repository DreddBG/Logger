using System;
using LoggerLib.Contracts;

namespace LoggerLib.Models.Appenders
{
    public class FileAppender : IAppender
    {
        public ReportLevel ReportLevel { get; set; } = 0;

        public FileAppender()
        {

        }

        public void WriteLine(ILog input)
        {
            throw new NotImplementedException();
        }
    }
}
