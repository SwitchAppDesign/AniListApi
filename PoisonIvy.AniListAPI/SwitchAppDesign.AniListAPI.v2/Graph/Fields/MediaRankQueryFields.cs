using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaRank
    {
        public MediaRank()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the rank
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The numerical rank of the media
        /// </summary>
        public GraphQLQueryField RankQueryField { get; private set; }

        /// <summary>
        /// The type of ranking
        /// </summary>
        public GraphQLQueryField TypeQueryField { get; private set; }

        /// <summary>
        /// The format the media is ranked within
        /// </summary>
        public GraphQLQueryField FormatQueryField { get; private set; }

        /// <summary>
        /// The year the media is ranked within
        /// </summary>
        public GraphQLQueryField YearQueryField { get; private set; }

        /// <summary>
        /// The season the media is ranked within
        /// </summary>
        public GraphQLQueryField SeasonQueryField { get; private set; }

        /// <summary>
        /// If the ranking is based on all time instead of a season/year
        /// </summary>
        public GraphQLQueryField AllTimeQueryField { get; private set; }

        /// <summary>
        /// String that gives context to the ranking type and time span
        /// </summary>
        public GraphQLQueryField ContextQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            RankQueryField = new GraphQLQueryField("rank", new FieldRules(false));
            TypeQueryField = new GraphQLQueryField("type", new FieldRules(false));
            FormatQueryField = new GraphQLQueryField("format", new FieldRules(false));
            YearQueryField = new GraphQLQueryField("year", new FieldRules(false));
            SeasonQueryField = new GraphQLQueryField("season", new FieldRules(false));
            AllTimeQueryField = new GraphQLQueryField("allTime", new FieldRules(false));
            ContextQueryField = new GraphQLQueryField("context", new FieldRules(false));
        }
    }
}
