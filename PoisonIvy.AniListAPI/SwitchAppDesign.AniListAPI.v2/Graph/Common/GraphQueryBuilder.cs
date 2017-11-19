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
        /// Graph query arguments to be used to build the query.
        /// </summary>
        private IList<object> GraphQueryArguments { get; set; }

        /// <summary>
        /// Graph query fields to be used to build the query.
        /// </summary>
        public IList<GraphQueryField> GraphQueryFields { get; set; }

        /// <summary>
        /// The type of query to be used.
        /// </summary>
        public AniListQueryType AniListQueryType { get; set; }

        /// <summary>
        /// Adds an argument to the query builder.
        /// </summary>
        public void AddArgument(object argument)
        {
            argument.IsValidArgumentType();

            GraphQueryArguments.Add(argument);
        }

        internal void InitializeBase(AniListQueryType queryType)
        {
            AniListQueryType = queryType;
            GraphQueryArguments = new List<object>();
        }

        /// <summary>
        /// Builds a graph query from a list of fields and arguments.
        /// </summary>
        protected internal GraphQuery BuildQuery()
        {
            var queryBuilder = new StringBuilder();

            BuildQueryType(queryBuilder);
            queryBuilder.Append(BuildQueryFields(GraphQueryFields));
            BuildQueryEnd(queryBuilder);

            return new GraphQuery(queryBuilder.ToString(), new Dictionary<string, object>());
        }

        /// <summary>
        /// Builds the first line of a graph query. 
        /// </summary>
        private void BuildQueryType(StringBuilder queryBuilder)
        {
            queryBuilder.AppendLine(GraphQueryArguments != null && GraphQueryArguments.Any() 
                ? $"query({BuildQueryArguments()}){{" 
                : "query{");

            queryBuilder.AppendLine(GraphQueryArguments != null && GraphQueryArguments.Any()
                ? $"{AniListQueryType.GetDescription()}({BuildQueryFieldArgumentsForVariables()}){{"
                : $"{AniListQueryType.GetDescription()}{{");
        }

        /// <summary>
        /// Builds the query argument component of a Graph Query. Example: query($arg1: String, $arg2: Int) $arg1 and $arg2 are the query arguments.
        /// </summary>
        private string BuildQueryArguments()
        {
            var queryArgumentBuilder = new StringBuilder();

            foreach (var argument in GraphQueryArguments)
            {
                var argType = argument.GetType();
                var argMethod = argType.GetMethod("Validate");
                var fieldName = argType.GetProperty("FieldName");
                var graphQueryArgumentVariableType = argType.GetProperty("GraphQueryArgumentVariableType");

                argMethod.Invoke(argument, new object[]{ AniListQueryType, false, null });

                queryArgumentBuilder.Append(argument == GraphQueryArguments.Last()
                    ? $"${fieldName.GetValue(argument)}: {graphQueryArgumentVariableType.GetValue(argument)}"
                    : $"${fieldName.GetValue(argument)}: {graphQueryArgumentVariableType.GetValue(argument)},");
            }

            return queryArgumentBuilder.ToString();
        }

        /// <summary>
        /// Builds the query argument component of a Graph Query. Example: media(arg1: $arg1, arg2: $arg2).
        /// <list type="bullet">
        /// <item><term>arg1 and arg2</term><description>are the query type arguments.</description></item>
        /// <item><term>$arg1 and $arg2</term><description>are the query arguments.</description></item>
        /// </list>
        /// </summary>
        private string BuildQueryFieldArgumentsForVariables()
        {
            var queryArgumentBuilder = new StringBuilder();

            foreach (var argument in GraphQueryArguments)
            {
                var argType = argument.GetType();
                var argMethod = argType.GetMethod("Validate");
                var fieldName = argType.GetProperty("FieldName");

                argMethod.Invoke(argument, new object[]{ AniListQueryType, false, null });

                queryArgumentBuilder.Append(argument == GraphQueryArguments.Last()
                    ? $"{fieldName.GetValue(argument)}: ${fieldName.GetValue(argument)}"
                    : $"{fieldName.GetValue(argument)}: ${fieldName.GetValue(argument)},");
            }

            return queryArgumentBuilder.ToString();
        }

        private string BuildQueryFieldArgumentsWithValues(IList<object> graphQueryArguments)
        {
            var queryArgumentBuilder = new StringBuilder();

            foreach (var argument in graphQueryArguments)
            {
                var argType = argument.GetType();
                var argMethod = argType.GetMethod("Validate");
                var fieldName = argType.GetProperty("FieldName");

                argMethod.Invoke(argument, new object[] { AniListQueryType, false, null });

                queryArgumentBuilder.Append(argument == graphQueryArguments.Last()
                    ? $"{fieldName.GetValue(argument)}: {GraphHelper.GetGraphQueryArgumentValue(argument)}"
                    : $"{fieldName.GetValue(argument)}: {GraphHelper.GetGraphQueryArgumentValue(argument)},");
            }

            return queryArgumentBuilder.ToString();
        }

        /// <summary>
        /// Builds the query field component of a graph query.
        /// </summary>
        private string BuildQueryFields(IList<GraphQueryField> graphQueryFields)
        {
            var builder = new StringBuilder();

            foreach (var field in graphQueryFields)
            {
                field.Validate(isAuthenticated: false);

                if (field.Arguments != null && field.Arguments.Any())
                {
                    builder.AppendLine($"{field.FieldName}({BuildQueryFieldArgumentsWithValues(field.Arguments.ToList())}){{");
                    builder.AppendLine(BuildQueryFields(field.Fields.ToList()));
                    builder.AppendLine("}");
                }
                else
                {
                    if (field.Fields != null && field.Fields.Any())
                    {
                        builder.AppendLine($"{field.FieldName}{{");
                        builder.AppendLine(BuildQueryFields(field.Fields.ToList()));
                        builder.AppendLine("}");
                    }
                    else
                    {
                        builder.AppendLine(field.FieldName);
                    }
                }
            }

            return builder.ToString();
        }

        private void BuildQueryEnd(StringBuilder builder)
        {
            builder.AppendLine("}");
            builder.AppendLine("}");
        }
    }
}