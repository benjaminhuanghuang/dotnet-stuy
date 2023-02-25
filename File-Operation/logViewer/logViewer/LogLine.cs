using System;

namespace PBiLogViewer
{
    internal record LogLine
    {
        public string DataMashupTrace { get;  init; }
        public string Level { get; init; }
        public string SomeRandomNumber { get; init; } //string as I don't know if this is always an int.
        public string Message { get; init; }

        public LogLine(string dataMashupTrace, string level, string someRandomNumber, string message)
        {
            DataMashupTrace = dataMashupTrace ?? throw new ArgumentNullException(nameof(dataMashupTrace));
            Level = level ?? throw new ArgumentNullException(nameof(level));
            SomeRandomNumber = someRandomNumber ?? throw new ArgumentNullException(nameof(someRandomNumber));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }
    }
}
