using System.Collections.Generic;

namespace PBiLogViewer
{
    public class AppOptions
    {
        public Dictionary<QueryType, QueryOptions> QueryConfiguration { get; set; }

        public AppOptions()
        {
            QueryConfiguration = new Dictionary<QueryType, QueryOptions>()
            {
                { QueryType.SQ, new QueryOptions() },
                { QueryType.DSQ, new QueryOptions() },
                { QueryType.DAX, new QueryOptions() },
            };
        }
    }
}
