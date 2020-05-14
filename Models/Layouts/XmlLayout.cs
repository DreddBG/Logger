using System.Text;

using LoggerLib.Contracts;

namespace LoggerLib.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format(ILog message)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<log>");
            sb.AppendLine($"  <data>{message.TimeStamp}</data>");
            sb.AppendLine($"  <level>{message.Level}</level>");
            sb.AppendLine($"  <message>{message.Message}</message>");
            sb.AppendLine("</log>");

            return sb.ToString().Trim();
        }
    }
}
