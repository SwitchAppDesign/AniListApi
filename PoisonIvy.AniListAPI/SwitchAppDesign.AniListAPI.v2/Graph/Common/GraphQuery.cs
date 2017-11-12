using System.Collections.Generic;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders
{
    public class GraphQuery
    {
        public GraphQuery(string query, Dictionary<string, object> variables)
        {
            Query = query;
            Variables = variables;
        }

        public string Query { get; set; }
        public Dictionary<string, object> Variables { get; set; }
    }
}