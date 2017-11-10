using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class AiringProgression
    {
        public AiringProgression()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The episode the stats were recorded at. .5 is the mid point between 2 episodes airing dates.
        /// </summary>
        public GraphQLQueryField EpisodeQueryField { get; private set; }

        /// <summary>
        /// The average score for the media
        /// </summary>
        public GraphQLQueryField ScoreQueryField { get; private set; }

        /// <summary>
        /// The amount of users watching the anime
        /// </summary>
        public GraphQLQueryField WatchingQueryField { get; private set; }

        private void InitializeProperties()
        {
            EpisodeQueryField = new GraphQLQueryField("episode", new FieldRules(false));
            ScoreQueryField = new GraphQLQueryField("score", new FieldRules(false));
            WatchingQueryField = new GraphQLQueryField("watching", new FieldRules(false));
        }
    }
}
