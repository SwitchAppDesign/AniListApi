using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaTag
    {
        public MediaTag()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the tag
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The name of the tag
        /// </summary>
        public GraphQLQueryField NameQueryField { get; private set; }

        /// <summary>
        /// A general description of the tag
        /// </summary>
        public GraphQLQueryField DescriptionQueryField { get; private set; }

        /// <summary>
        /// The categories of tags this tag belongs to
        /// </summary>
        public GraphQLQueryField CategoryQueryField { get; private set; }

        /// <summary>
        /// The relevance ranking of the tag out of the 100 for this media
        /// </summary>
        public GraphQLQueryField RankQueryField { get; private set; }

        /// <summary>
        /// If the tag could be a spoiler for any media
        /// </summary>
        public GraphQLQueryField IsGeneralSpoilerQueryField { get; private set; }

        /// <summary>
        /// If the tag is a spoiler for this media
        /// </summary>
        public GraphQLQueryField IsMediaSpoilerQueryField { get; private set; }

        /// <summary>
        /// If the tag is only for adult 18+ media
        /// </summary>
        public GraphQLQueryField IsAdultQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            NameQueryField = new GraphQLQueryField("name", new FieldRules(false));
            DescriptionQueryField = new GraphQLQueryField("description", new FieldRules(false));
            CategoryQueryField = new GraphQLQueryField("category", new FieldRules(false));
            RankQueryField = new GraphQLQueryField("rank", new FieldRules(false));
            IsGeneralSpoilerQueryField = new GraphQLQueryField("isGeneralSpoiler", new FieldRules(false));
            IsMediaSpoilerQueryField = new GraphQLQueryField("isMediaSpoiler", new FieldRules(false));
            IsAdultQueryField = new GraphQLQueryField("isAdult", new FieldRules(false));
        }
    }
}
