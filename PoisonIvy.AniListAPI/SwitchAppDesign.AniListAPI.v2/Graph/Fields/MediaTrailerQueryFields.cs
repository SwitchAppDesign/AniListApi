using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaTrailer
    {
        public MediaTrailer()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The trailer video id
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The site the video is hosted by (Currently either youtube or dailymotion
        /// </summary>
        public GraphQLQueryField SiteQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            SiteQueryField = new GraphQLQueryField("site", new FieldRules(false));
        }
    }
}
