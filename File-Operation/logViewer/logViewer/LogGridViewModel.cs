using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Nodes;
using System.Windows.Shapes;

namespace PBiLogViewer
{
    internal class LogGridViewModel
    {
        public ObservableCollection<QueryModel> QueryModels { get; } = new ObservableCollection<QueryModel>();

        public LogGridViewModel()
        {
        }

        public void ClearLogLines()
        {
            QueryModels.Clear();
        }

        public void AddLogLines(IReadOnlyList<LogLine> logLines)
        {
            var lineNumber = QueryModels.Count == 0 ? 1 : QueryModels[0].LineNumber + 1; //1 based
            foreach(var log in logLines)
            {
                var (queryType, query) = GetQuery(log);
                if (queryType != null && query != null)
                {
                    QueryModels.Insert(0, new QueryModel(lineNumber, queryType.Value, query));
                }
                lineNumber++;
            }
        }

        private static (QueryType? queryType, string? query) GetQuery(LogLine log)
        {
            QueryType? queryType = log.Message.Contains("Generating DataShape", StringComparison.InvariantCultureIgnoreCase)
                ? QueryType.SQ
                : log.Message.Contains("Generated DataShape", StringComparison.InvariantCultureIgnoreCase)
                ? QueryType.DSQ
                : log.Message.Contains("Running the query.", StringComparison.InvariantCultureIgnoreCase)
                ? QueryType.DAX
                : null;

            if (queryType.HasValue)
            {
                var logLine = JsonNode.Parse(log.Message[log.Message.IndexOf('{')..]);
                var innerMessage = logLine!["Message"]!.GetValue<string>();
                var queryStart = innerMessage.IndexOf("<ccon>") + "<ccon>".Length;
                var queryEnd = innerMessage.IndexOf("</ccon>");
                var query = innerMessage[queryStart..queryEnd];
                return (queryType, query);
            }

            return (null, null);
        }
    }
}
 