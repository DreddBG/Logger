namespace LoggerLib.Contracts
{
    public interface ILogger
    {
        void Info(string TimeStamp, string Message);
        void Warning(string TimeStamp, string Message);
        void Error(string TimeStamp, string Message);
        void Critical(string TimeStamp, string Message);
        void Fatal(string TimeStamp, string Message);
    }
}
