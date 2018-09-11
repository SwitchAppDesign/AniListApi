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
        internal QueryArgumentRules(
            bool authenticationRequired, 
            int? maxValue, 
            GraphQueryArgument<object> requiresArgument, 
            IEnumerable<AniListQueryType> allowedQueryTypes)
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
        public GraphQueryArgument<object> RequiresArgument { get; }

        /// <summary>
        /// The query types that this query argument is allowed to be used in.
        /// </summary>
        public IEnumerable<AniListQueryType> AllowedQueryTypes { get; }
    }
}