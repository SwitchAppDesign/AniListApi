using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Common
{
    /// <summary>
    /// Rules and restictions applied to a GraphQueryField.
    /// </summary>
    public class FieldRules
    {
        /// <summary>
        /// Constructs the applicable rules and restrictions for a GraphQueryField.
        /// </summary>
        internal FieldRules(bool authenticationRequired, IEnumerable<AniListQueryType> allowedQueryTypes)
        {
            AuthenticationRequired = authenticationRequired;
            AllowedQueryTypes = allowedQueryTypes;
        }

        /// <summary>
        /// Whether the field requires authentication to be used or not.
        /// </summary>
        public bool AuthenticationRequired { get; }

        /// <summary>
        /// The query types that this query argument is allowed to be used in.
        /// </summary>
        public IEnumerable<AniListQueryType> AllowedQueryTypes { get; }
    }
}