using LoggerLib.Contracts;

namespace LoggerLib.Models
{
    public class Log : ILog
    {
        private string _timeStamp;
        private string _message;
        private ReportLevel _level;

        public Log(string timeStamp, string message, ReportLevel level)
        {
            this._timeStamp = timeStamp;
            this._message = message;
            this._level = level;
        }

        public string TimeStamp { get => this._timeStamp; }

        public string Message { get => this._message; }

        public ReportLevel Level { get => this._level; }
    }
}
