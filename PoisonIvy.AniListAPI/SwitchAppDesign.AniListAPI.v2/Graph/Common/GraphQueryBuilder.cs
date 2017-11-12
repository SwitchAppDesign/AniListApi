using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders
{
    /// <summary>
    /// Base behavior of the graph query builder classes.
    /// </summary>
    public abstract class GraphQueryBuilder
    {
        /// <summary>
        /// Builds a graph query from a list of fields and arguments.
        /// </summary>
        /// <param name="aniListQueryType">The type of AniList graph query.</param>
        /// <param name="graphQueryArguments">The list of arguments to be used in the graph query.</param>
        /// <param name="graphQueryFields">The list of fields to be used in the graph query.</param>
        protected GraphQuery BuildQuery(
            AniListQueryType aniListQueryType,
            IList<GraphQLQueryArgument<object>> graphQueryArguments,
            IList<GraphQLQueryField> graphQueryFields)
        {
            var queryBuilder = new StringBuilder();



            return new GraphQuery(string.Empty, new Dictionary<string, object>());
        }

        private void BuildQueryType(StringBuilder queryBuilder, AniListQueryType aniListQueryType, IList<GraphQLQueryArgument<object>> graphQueryArguments)
        {
            queryBuilder.AppendLine(graphQueryArguments != null && graphQueryArguments.Any() ? $"query({BuildQueryArguments(aniListQueryType, graphQueryArguments)}){{" : "query{");
        }

        /// <summary>
        /// Builds the query argument component of a Graph Query. Example: query($arg1: String, $arg2: Int) $arg1 and $arg2 are the query arguments.
        /// </summary>
        private string BuildQueryArguments(AniListQueryType aniListQueryType, IList<GraphQLQueryArgument<object>> graphQueryArguments)
        {
            

            foreach (var argument in graphQueryArguments)
            {

                var validationWrapper =  argument.QueryArgumentRules.IsQueryArgumentValid(
                    argument: argument,
                    queryType: aniListQueryType,
                    isAuthenticated: false);

                if (!validationWrapper.IsValid)
                    throw new ArgumentException(validationWrapper.Reason, argument.GetType().Name);

                argument.Value.GetType();
            }

            return "";
        }

        
    }
}