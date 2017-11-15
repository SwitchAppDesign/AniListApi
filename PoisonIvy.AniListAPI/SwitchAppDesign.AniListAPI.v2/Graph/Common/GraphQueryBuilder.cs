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
        protected internal GraphQuery BuildQuery(
            AniListQueryType aniListQueryType,
            IList<GraphQueryArgument<object>> graphQueryArguments,
            IList<GraphQueryField> graphQueryFields)
        {
            var queryBuilder = new StringBuilder();

            BuildQueryType(queryBuilder, aniListQueryType, graphQueryArguments);

            return new GraphQuery(string.Empty, new Dictionary<string, object>());
        }

        /// <summary>
        /// Builds the first line of a graph query. 
        /// </summary>
        private void BuildQueryType(StringBuilder queryBuilder, AniListQueryType aniListQueryType, IList<GraphQueryArgument<object>> graphQueryArguments)
        {
            queryBuilder.AppendLine(graphQueryArguments != null && graphQueryArguments.Any() 
                ? $"query({BuildQueryArguments(aniListQueryType, graphQueryArguments)}){{" 
                : "query{");

            queryBuilder.AppendLine(graphQueryArguments != null && graphQueryArguments.Any()
                ? $"{aniListQueryType.GetDescription()}({BuildQueryTypeArguments(graphQueryArguments)}){{"
                : $"{aniListQueryType.GetDescription()}{{");
        }

        /// <summary>
        /// Builds the query argument component of a Graph Query. Example: query($arg1: String, $arg2: Int) $arg1 and $arg2 are the query arguments.
        /// </summary>
        private string BuildQueryArguments(AniListQueryType aniListQueryType, IList<GraphQueryArgument<object>> graphQueryArguments)
        {
            var queryArgumentBuilder = new StringBuilder();

            foreach (var argument in graphQueryArguments)
            {
                argument.ValidateArgument(queryType: aniListQueryType, isAuthenticated: false);

                queryArgumentBuilder.Append(argument == graphQueryArguments.Last()
                    ? $"${argument.FieldName}: {argument.GraphQueryArgumentVariableType}"
                    : $"${argument.FieldName}: {argument.GraphQueryArgumentVariableType},");
            }

            return queryArgumentBuilder.ToString();
        }

        /// <summary>
        /// Builds the query type argument component of a Graph Query. Example: media(arg1: $arg1, arg2: $arg2).
        /// <list type="bullet">
        /// <item><term>arg1 and arg2</term><description>are the query type arguments.</description></item>
        /// <item><term>$arg1 and $arg2</term><description>are the query arguments.</description></item>
        /// </list>
        /// </summary>
        private string BuildQueryTypeArguments(IList<GraphQueryArgument<object>> graphQueryArguments)
        {
            var queryArgumentBuilder = new StringBuilder();

            foreach (var argument in graphQueryArguments)
            {
                queryArgumentBuilder.Append(argument == graphQueryArguments.Last()
                    ? $"{argument.FieldName}: ${argument.FieldName}"
                    : $"{argument.FieldName}: ${argument.FieldName},");
            }

            return queryArgumentBuilder.ToString();
        }
    }
}