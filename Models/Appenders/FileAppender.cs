using System;
using System.IO;
using System.Text;
using LoggerLib.Contracts;

namespace LoggerLib.Models.Appenders
{
    public class FileAppender : IAppender
    {
        private ILayout layout;
        private string _filePath;

        public ReportLevel ReportLevel { get; set; } = 0;

        public FileAppender(ILayout layout, string filePath)
        {
            this.layout = layout;
            this._filePath = filePath;
        }

        public void WriteLine(ILog input)
        {
            if (input.Level >= this.ReportLevel)
            {
                var output = this.layout.Format(input);
                File.AppendAllTextAsync(this._filePath, output + "\n");
            }
        }
    }
}
