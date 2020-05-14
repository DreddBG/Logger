using LoggerLib.Models;

namespace LoggerLib.Contracts
{
    public interface IAppender
    {
        void WriteLine(ILog input);
    }
}
