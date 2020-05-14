using LoggerLib.Models;

namespace LoggerLib.Contracts
{
    public interface ILog
    {
        string TimeStamp { get; }
        string Message { get; }

        ReportLevel Level { get; }
    }
}
