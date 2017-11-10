using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaStreamingEpisode
    {
        public MediaStreamingEpisode()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Title of the episode
        /// </summary>
        public GraphQLQueryField TitleQueryField { get; private set; }

        /// <summary>
        /// Url of episode image thumbnail
        /// </summary>
        public GraphQLQueryField ThumbnailQueryField { get; private set; }

        /// <summary>
        /// The url of the episode
        /// </summary>
        public GraphQLQueryField UrlQueryField { get; private set; }

        /// <summary>
        /// The site location of the streaming episodes
        /// </summary>
        public GraphQLQueryField SiteQueryField { get; private set; }

        private void InitializeProperties()
        {
            TitleQueryField = new GraphQLQueryField("title", new FieldRules(false));
            ThumbnailQueryField = new GraphQLQueryField("thumbnail", new FieldRules(false));
            UrlQueryField = new GraphQLQueryField("url", new FieldRules(false));
            SiteQueryField = new GraphQLQueryField("site", new FieldRules(false));
        }
    }
}
