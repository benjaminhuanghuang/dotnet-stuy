// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PowerBILogReaderFindQueries
{
    public class Program
    {
        private const string JavascriptTemplate = @"{{ 
            ""SQ"":{0}, 
            ""DSQ"":{1}, 
            ""DAX"":""{2}""
            }}";

        [STAThread]
        static void Main()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Microsoft\Power BI Desktop Store App\Traces");
            var directory = new DirectoryInfo(path);
            FileInfo? newest = null;

            do
            {
                Console.WriteLine("");
                foreach (var file in directory.GetFiles())
                {
                    if (newest is null || newest.LastWriteTimeUtc < file.LastWriteTimeUtc)
                    {
                        newest = file;
                    }
                }

                if (newest is null)
                {
                    Console.WriteLine("No trace files found");
                    return;
                }

                using (var sr = new StreamReader(newest.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
                {
                    var (sq, dsq, dax) = FindNewestQueries(sr);

                    var jsonOptions = new JsonSerializerOptions() { WriteIndented = true };
                    var javascriptText = string.Format(
                        JavascriptTemplate,
                        JsonNode.Parse(sq).ToJsonString(jsonOptions),
                        JsonNode.Parse(dsq).ToJsonString(jsonOptions),
                        dax.Replace("\"", "\"\"")); //replace double quote with two double quotes

                    Clipboard.SetText(javascriptText);
                }
                Console.WriteLine("Copied the latest queries");
                Console.WriteLine("Press escape to quit. Press any other key to copied the latest queries.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static (string?, string?, string?) FindNewestQueries(StreamReader sr)
        {
            var queryNames = new string[] { "Generating DataShape", "Generated DataShape", "Running the query." };
            string?[]? queriesToFind = null;
            var expecting = 0;
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                var found = -1;
                for (var i = 0; i < queryNames.Length; i++)
                {
                    if (IsMatch(line, queryNames[i]))
                    {
                        found = i;
                        break;
                    }
                }

                if (found == -1)
                    continue;

                if (found == 0)
                {
                    expecting = 0;
                    queriesToFind = new string[queryNames.Length];
                }

                if (found != expecting)
                {
                    //erh something is screwed up ignore this set of three and hope it wasn't the last one
                    expecting = 0;
                    queriesToFind = new string[queryNames.Length];
                    continue;
                }

                queriesToFind![found] = ParseQueryLine(line!); //can't be a match if null so this can't be null
                expecting = (expecting + 1) % 3;
            }

            return (queriesToFind[0], queriesToFind[1], queriesToFind[2]);
        }

        static bool IsMatch(string? line, string queryName)
        {
            if (line is not null && line.Contains(queryName, StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

        static string ParseQueryLine(string line)
        {
            var logLine = JsonNode.Parse(line[line.IndexOf('{')..]);
            var message = logLine!["Message"]!.GetValue<string>();
            var queryStart = message.IndexOf("<ccon>") + "<ccon>".Length;
            var queryEnd = message.IndexOf("</ccon>");
            var query = message[queryStart..queryEnd];
            return query;
        }
    }
}