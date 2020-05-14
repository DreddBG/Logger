using System;
using LoggerLib.Contracts;

namespace LoggerLib.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private ILayout layout;

        public ReportLevel ReportLevel { get; set; } = 0;

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public void WriteLine(ILog input)
        {
            if (input.Level >= this.ReportLevel)
            {
                Console.ForegroundColor = getColor(input.Level);
                Console.WriteLine(this.layout.Format(input));
                Console.ResetColor();
            }
        }

        private ConsoleColor getColor(ReportLevel level)
        {
            return level switch
            {
                ReportLevel.Warning => ConsoleColor.Yellow,
                ReportLevel.Error => ConsoleColor.Red,
                ReportLevel.Critical => ConsoleColor.DarkRed,
                ReportLevel.Fatal => ConsoleColor.DarkMagenta,
                _ => ConsoleColor.White
            };
        }
    }
}
