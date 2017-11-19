using System.Collections.Generic;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders
{
    public class GraphQuery
    {
        internal GraphQuery(string query, string variables)
        {
            Query = query;
            Variables = variables;
        }

        public string Query { get; set; }
        public string Variables { get; set; }
    }
}