using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class UserStats
    {
        public UserStats()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The amount of anime the user has watched in minutes
        /// </summary>
        public GraphQLQueryField WatchedTimeQueryField { get; private set; }

        /// <summary>
        /// The amount of manga chapters the user has read
        /// </summary>
        public GraphQLQueryField ChaptersReadQueryField { get; private set; }

        public GraphQLQueryField ActivityHistoryQueryField { get; private set; }

        public GraphQLQueryField AnimeStatusDistributionQueryField { get; private set; }

        public GraphQLQueryField MangaStatusDistributionQueryField { get; private set; }

        public GraphQLQueryField AnimeScoreDistributionQueryField { get; private set; }

        public GraphQLQueryField MangaScoreDistributionQueryField { get; private set; }

        private void InitializeProperties()
        {
            WatchedTimeQueryField = new GraphQLQueryField("watchedTime", new FieldRules(false));
            ChaptersReadQueryField = new GraphQLQueryField("chaptersRead", new FieldRules(false));
            ActivityHistoryQueryField = new GraphQLQueryField("activityHistory", new FieldRules(false));
            AnimeStatusDistributionQueryField = new GraphQLQueryField("animeStatusDistribution", new FieldRules(false));
            MangaStatusDistributionQueryField = new GraphQLQueryField("mangaStatusDistribution", new FieldRules(false));
            AnimeScoreDistributionQueryField = new GraphQLQueryField("animeScoreDistribution", new FieldRules(false));
            MangaScoreDistributionQueryField = new GraphQLQueryField("mangaScoreDistribution", new FieldRules(false));
        }
    }
}
