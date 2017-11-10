using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaExternalLink
    {
        public MediaExternalLink()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the external link
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The url of the external link
        /// </summary>
        public GraphQLQueryField UrlQueryField { get; private set; }

        /// <summary>
        /// The site location of the external link
        /// </summary>
        public GraphQLQueryField SiteQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            UrlQueryField = new GraphQLQueryField("url", new FieldRules(false));
            SiteQueryField = new GraphQLQueryField("site", new FieldRules(false));
        }
    }
}
