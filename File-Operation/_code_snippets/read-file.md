
## Read file line by line
```
FileStreamOptions ReadOnlyFileOptions = new FileStreamOptions() { Access = FileAccess.Read, Mode = FileMode.Open, Share = FileShare.ReadWrite };

// using will close the file automatically when it is out of scope 
using var logFile = new StreamReader(new FileStream(logFilePath, ReadOnlyFileOptions));
var parsedLogLines = new List<LogLine>();


while (!logFile.EndOfStream)
{
    // read one line from the log file
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
```