using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class Review
    {
        public Review()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the review
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The id of the review's creator
        /// </summary>
        public GraphQLQueryField UserIdQueryField { get; private set; }

        /// <summary>
        /// The id of the review's media
        /// </summary>
        public GraphQLQueryField MediaIdQueryField { get; private set; }

        /// <summary>
        /// For which type of media the review is for
        /// </summary>
        public GraphQLQueryField MediaTypeQueryField { get; private set; }

        /// <summary>
        /// A short summary of the review
        /// </summary>
        public GraphQLQueryField SummaryQueryField { get; private set; }

        /// <summary>
        /// The main review body text
        /// </summary>
        public GraphQLQueryField BodyQueryField { get; private set; }

        /// <summary>
        /// The total user rating of the review
        /// </summary>
        public GraphQLQueryField RatingQueryField { get; private set; }

        /// <summary>
        /// The amount of user ratings of the review
        /// </summary>
        public GraphQLQueryField RatingAmountQueryField { get; private set; }

        /// <summary>
        /// The rating of the review by currently authenticated user
        /// </summary>
        public GraphQLQueryField UserRatingQueryField { get; private set; }

        /// <summary>
        /// The review score of the media
        /// </summary>
        public GraphQLQueryField ScoreQueryField { get; private set; }

        /// <summary>
        /// If the review is not yet publicly published and is only viewable by creator
        /// </summary>
        public GraphQLQueryField _privateQueryField { get; private set; }

        /// <summary>
        /// The url for the review page on the AniList website
        /// </summary>
        public GraphQLQueryField SiteUrlQueryField { get; private set; }

        /// <summary>
        /// The time of the thread creation
        /// </summary>
        public GraphQLQueryField CreatedAtQueryField { get; private set; }

        /// <summary>
        /// The time of the thread last update
        /// </summary>
        public GraphQLQueryField UpdatedAtQueryField { get; private set; }

        /// <summary>
        /// The id of the review's creator
        /// </summary>
        public GraphQLQueryField UserQueryField { get; private set; }

        /// <summary>
        /// The id of the review's media
        /// </summary>
        public GraphQLQueryField MediaQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            UserIdQueryField = new GraphQLQueryField("userId", new FieldRules(false));
            MediaIdQueryField = new GraphQLQueryField("mediaId", new FieldRules(false));
            MediaTypeQueryField = new GraphQLQueryField("mediaType", new FieldRules(false));
            SummaryQueryField = new GraphQLQueryField("summary", new FieldRules(false));
            BodyQueryField = new GraphQLQueryField("body", new FieldRules(false));
            RatingQueryField = new GraphQLQueryField("rating", new FieldRules(false));
            RatingAmountQueryField = new GraphQLQueryField("ratingAmount", new FieldRules(false));
            UserRatingQueryField = new GraphQLQueryField("userRating", new FieldRules(false));
            ScoreQueryField = new GraphQLQueryField("score", new FieldRules(false));
            _privateQueryField = new GraphQLQueryField("_private", new FieldRules(false));
            SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
            CreatedAtQueryField = new GraphQLQueryField("createdAt", new FieldRules(false));
            UpdatedAtQueryField = new GraphQLQueryField("updatedAt", new FieldRules(false));
            UserQueryField = new GraphQLQueryField("user", new FieldRules(false));
            MediaQueryField = new GraphQLQueryField("media", new FieldRules(false));
        }
    }
}
