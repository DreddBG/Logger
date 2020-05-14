using LoggerLib.Contracts;

namespace LoggerLib.Models.Layouts
{
    public class SimpleLayout : ILayout
    {
        //date-time - report level - message
        public string Format(ILog message)
        {
            return $"{message.TimeStamp} - {message.Level.ToString()} - {message.Message}";
        }
    }
}
