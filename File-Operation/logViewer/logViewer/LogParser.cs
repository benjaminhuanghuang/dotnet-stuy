using System;
using System.Collections.Generic;
using System.IO;

namespace PBiLogViewer
{
    internal class LogParser
    {
        public readonly FileStreamOptions ReadOnlyFileOptions = new FileStreamOptions() { Access = FileAccess.Read, Mode = FileMode.Open, Share = FileShare.ReadWrite };
        private readonly string logFilePath;
        private int lastReadLogNumber = 0;

        public LogParser(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public IReadOnlyList<LogLine> GetLogsLines()
        {
            using var logFile = new StreamReader(new FileStream(logFilePath, ReadOnlyFileOptions));
            var parsedLogLines = new List<LogLine>();

            var lineNumber = 0;
            while (!logFile.EndOfStream)
            {
                var line = logFile.ReadLine();
                if (line == null)
                {
                    break;
                }

                lineNumber++;
                if (lineNumber < lastReadLogNumber)
                {
                    continue;
                }
                
                parsedLogLines.Add(ParseLogLine(line));
            }

            lastReadLogNumber = lineNumber;
            return parsedLogLines;
        }

        private static LogLine ParseLogLine(string line)
        {
            var numberOfArgsToRead = 4;
            var lastArgIndex = -2;
            var args = new string[numberOfArgsToRead];
            while (numberOfArgsToRead > 0)
            {
                var endOfCurrentArgIndex = numberOfArgsToRead > 1 ? line.IndexOf(" ", Math.Max(lastArgIndex, 0)) - 1 : line.Length - 1;
                args[^numberOfArgsToRead] = line.Substring(lastArgIndex + 2, endOfCurrentArgIndex + 1);
                numberOfArgsToRead--;
            }

            return new LogLine(args[0], args[1], args[2], args[3]);
        }
    }
}
