using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available review query fields.
    /// </summary>
	public class ReviewQueryFields
	{
		internal ReviewQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the review
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The id of the review's creator
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of the review's media
		/// </summary>
		public GraphQueryField MediaIdQueryField()
		{
			return MediaId;
		}

		/// <summary>
		/// For which type of media the review is for
		/// </summary>
		public GraphQueryField MediaTypeQueryField()
		{
			return MediaType;
		}

		/// <summary>
		/// A short summary of the review
		/// </summary>
		public GraphQueryField SummaryQueryField()
		{
			return Summary;
		}

		/// <summary>
		/// The main review body text
		/// </summary>
		public GraphQueryField BodyQueryField()
		{
			return Body;
		}

		/// <summary>
		/// The total user rating of the review
		/// </summary>
		public GraphQueryField RatingQueryField()
		{
			return Rating;
		}

		/// <summary>
		/// The amount of user ratings of the review
		/// </summary>
		public GraphQueryField RatingAmountQueryField()
		{
			return RatingAmount;
		}

		/// <summary>
		/// The rating of the review by currently authenticated user
		/// </summary>
		public GraphQueryField UserRatingQueryField()
		{
			return UserRating;
		}

		/// <summary>
		/// The review score of the media
		/// </summary>
		public GraphQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// If the review is not yet publicly published and is only viewable by creator
		/// </summary>
		public GraphQueryField _privateQueryField()
		{
			return _private;
		}

		/// <summary>
		/// The url for the review page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// The time of the thread creation
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The time of the thread last update
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

        /// <summary>
        /// The id of the review's creator.
        /// <param name="fields">The list of user query fields (found in <see cref="UserQueryFields"/>) to be used in the graph query (at least of user query field is required).</param>
        /// </summary>
        public GraphQueryField UserQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({User.GetType().Name}) requires at least one user query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(UserQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid user query fields {fields.Where(x => x.ParentClassType != typeof(UserQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return User.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The id of the review's media
        /// <param name="fields">The list of media query fields (found in <see cref="MediaQueryFields"/>) to be used in the graph query (at least of media query field is required).</param>
        /// </summary>
        public GraphQueryField MediaQueryField(IList<GraphQueryField> fields)
        {
            if (fields == null || !fields.Any())
                throw new GraphQueryFieldInvalidException($"Query field ({Media.GetType().Name}) requires at least one media query field.");

            if (fields.Any(x => x.ParentClassType != typeof(UserQueryFields)))
                throw new GraphQueryFieldInvalidException($"The following fields are not valid media query fields {fields.Where(x => x.ParentClassType != typeof(UserQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

            return Media.GetGraphFieldAndSetFieldArguments(fields);
        }

		private GraphQueryField Id { get; set; }
		private GraphQueryField UserId { get; set; }
		private GraphQueryField MediaId { get; set; }
		private GraphQueryField MediaType { get; set; }
		private GraphQueryField Summary { get; set; }
		private GraphQueryField Body { get; set; }
		private GraphQueryField Rating { get; set; }
		private GraphQueryField RatingAmount { get; set; }
		private GraphQueryField UserRating { get; set; }
		private GraphQueryField Score { get; set; }
		private GraphQueryField _private { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField CreatedAt { get; set; }
		private GraphQueryField UpdatedAt { get; set; }
		private GraphQueryField User { get; set; }
		private GraphQueryField Media { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			UserId = new GraphQueryField("userId", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			MediaId = new GraphQueryField("mediaId", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			MediaType = new GraphQueryField("mediaType", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			Summary = new GraphQueryField("summary", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			Body = new GraphQueryField("body", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			Rating = new GraphQueryField("rating", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			RatingAmount = new GraphQueryField("ratingAmount", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			UserRating = new GraphQueryField("userRating", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			Score = new GraphQueryField("score", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			_private = new GraphQueryField("_private", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			SiteUrl = new GraphQueryField("siteUrl", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			CreatedAt = new GraphQueryField("createdAt", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			UpdatedAt = new GraphQueryField("updatedAt", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			User = new GraphQueryField("user", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
			Media = new GraphQueryField("media", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Review }));
		}
	}
}
