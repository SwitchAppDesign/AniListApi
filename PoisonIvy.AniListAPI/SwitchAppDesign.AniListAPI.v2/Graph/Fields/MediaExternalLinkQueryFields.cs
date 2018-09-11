using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media external link query fields.
    /// </summary>
    public class MediaExternalLinkQueryFields
    {
        private readonly List<AniListQueryType> _allowedQueryTypes;
        private readonly AniListQueryType _queryType;

        internal MediaExternalLinkQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.MediaList };
        }

        /// <summary>
        /// The id of the external link
        /// </summary>
        public GraphQueryField IdQueryField()
        {
            return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The url of the external link
        /// </summary>
        public GraphQueryField UrlQueryField()
        {
            return new GraphQueryField("url", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The site location of the external link
        /// </summary>
        public GraphQueryField SiteQueryField()
        {
            return new GraphQueryField("site", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
        {
            return new FieldRules(authenticationRequired, _allowedQueryTypes);
        }
    }
}
