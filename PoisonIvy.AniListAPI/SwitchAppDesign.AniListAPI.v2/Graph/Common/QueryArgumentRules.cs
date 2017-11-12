using System;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    /// <summary>
    /// Rules and restictions applied to a GraphQueryArgument.
    /// </summary>
    public class QueryArgumentRules
    {
        /// <summary>
        /// Constructs the applicable rules and restrictions for a GraphQueryArgument.
        /// </summary>
        public QueryArgumentRules(bool authenticationRequired, int? maxValue, GraphQLQueryArgument<object> requiresArgument, IEnumerable<AniListQueryType> allowedQueryTypes)
        {
            AuthenticationRequired = authenticationRequired;
            MaxValue = maxValue;
            RequiresArgument = requiresArgument;
            AllowedQueryTypes = allowedQueryTypes;
        }

        /// <summary>
        /// Whether the field requires authentication to be used or not.
        /// </summary>
        public bool AuthenticationRequired { get; }

        /// <summary>
        /// The max allowed value (only applicable for integer based fields).
        /// </summary>
        public int? MaxValue { get; }

        /// <summary>
        /// The query argument this query argument is dependant on.
        /// </summary>
        public GraphQLQueryArgument<object> RequiresArgument { get; }

        /// <summary>
        /// The query types that this query argument is allowed to be used in.
        /// </summary>
        public IEnumerable<AniListQueryType> AllowedQueryTypes { get; }

        /// <summary>
        /// Checks all non-null conditions to see if the argument is in a valid state.
        /// </summary>
        public RulesValidationWrapper IsQueryArgumentValid(GraphQLQueryArgument<object> argument, AniListQueryType queryType, bool isAuthenticated, IList<GraphQLQueryArgument<object>> graphQueryArguments = null)
        {
            if (argument.Value == null)
                return new RulesValidationWrapper(false, $"Argument ({argument.GetType().Name}) must have value.");

            var maxValue = argument.Value.GetType().IsInteger() ? int.Parse($"{argument.Value}") : -1;

            if (!AllowedQueryTypes.Contains(queryType))
                return new RulesValidationWrapper(false, $"Argument ({argument.GetType().Name}) is not allowed to be used in query type ({queryType.GetDescription()})");

            if (AuthenticationRequired && !isAuthenticated)
                return new RulesValidationWrapper(false, $"Argument ({argument.GetType().Name}) requires authentication to be accessed.");

            if (MaxValue.HasValue && maxValue != -1 && maxValue > MaxValue)
                return new RulesValidationWrapper(false, $"Argument ({argument.GetType().Name}) has a max value of {MaxValue}");

            if (RequiresArgument != null && graphQueryArguments != null && graphQueryArguments.All(x => x.FieldName != RequiresArgument.FieldName))
                return new RulesValidationWrapper(false, $"Argument ({RequiresArgument.GetType().Name}) is required for argument ({argument.GetType().Name}).");

            return new RulesValidationWrapper(true, null);
        }
    }

    /// <summary>
    /// Small wrapper class for graph argument and graph field rules validation.
    /// </summary>
    public class RulesValidationWrapper
    {
        /// <summary>
        /// Creates a RulesValidationWrapper stating whether a graph argument or graph field is valid.
        /// </summary>
        public RulesValidationWrapper(bool isValid, string reason)
        {
            IsValid = isValid;
            Reason = reason;
        }

        /// <summary>
        /// Indicates whether a graph argument or graph field is valid.
        /// </summary>
        public bool IsValid { get; }

        /// <summary>
        /// The reason why the graph argument or graph field is invalid.
        /// </summary>
        public string Reason { get; }
    }
}