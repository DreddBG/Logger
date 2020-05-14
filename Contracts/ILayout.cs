using LoggerLib.Contracts;
using LoggerLib.Models;

namespace LoggerLib.Contracts
{
    public interface ILayout
    {
        string Format(ILog message);
    }
}
