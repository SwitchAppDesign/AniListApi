using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ReviewQueryFields
	{
		public ReviewQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the review
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The id of the review's creator
		/// </summary>
		public GraphQLQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of the review's media
		/// </summary>
		public GraphQLQueryField MediaIdQueryField()
		{
			return MediaId;
		}

		/// <summary>
		/// For which type of media the review is for
		/// </summary>
		public GraphQLQueryField MediaTypeQueryField()
		{
			return MediaType;
		}

		/// <summary>
		/// A short summary of the review
		/// </summary>
		public GraphQLQueryField SummaryQueryField()
		{
			return Summary;
		}

		/// <summary>
		/// The main review body text
		/// </summary>
		public GraphQLQueryField BodyQueryField()
		{
			return Body;
		}

		/// <summary>
		/// The total user rating of the review
		/// </summary>
		public GraphQLQueryField RatingQueryField()
		{
			return Rating;
		}

		/// <summary>
		/// The amount of user ratings of the review
		/// </summary>
		public GraphQLQueryField RatingAmountQueryField()
		{
			return RatingAmount;
		}

		/// <summary>
		/// The rating of the review by currently authenticated user
		/// </summary>
		public GraphQLQueryField UserRatingQueryField()
		{
			return UserRating;
		}

		/// <summary>
		/// The review score of the media
		/// </summary>
		public GraphQLQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// If the review is not yet publicly published and is only viewable by creator
		/// </summary>
		public GraphQLQueryField _privateQueryField()
		{
			return _private;
		}

		/// <summary>
		/// The url for the review page on the AniList website
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// The time of the thread creation
		/// </summary>
		public GraphQLQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The time of the thread last update
		/// </summary>
		public GraphQLQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// The id of the review's creator
		/// </summary>
		public GraphQLQueryField UserQueryField()
		{
			return User;
		}

		/// <summary>
		/// The id of the review's media
		/// </summary>
		public GraphQLQueryField MediaQueryField()
		{
			return Media;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField UserId { get; set; }
		private GraphQLQueryField MediaId { get; set; }
		private GraphQLQueryField MediaType { get; set; }
		private GraphQLQueryField Summary { get; set; }
		private GraphQLQueryField Body { get; set; }
		private GraphQLQueryField Rating { get; set; }
		private GraphQLQueryField RatingAmount { get; set; }
		private GraphQLQueryField UserRating { get; set; }
		private GraphQLQueryField Score { get; set; }
		private GraphQLQueryField _private { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField CreatedAt { get; set; }
		private GraphQLQueryField UpdatedAt { get; set; }
		private GraphQLQueryField User { get; set; }
		private GraphQLQueryField Media { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			UserId = new GraphQLQueryField("userId", new FieldRules(false));
			MediaId = new GraphQLQueryField("mediaId", new FieldRules(false));
			MediaType = new GraphQLQueryField("mediaType", new FieldRules(false));
			Summary = new GraphQLQueryField("summary", new FieldRules(false));
			Body = new GraphQLQueryField("body", new FieldRules(false));
			Rating = new GraphQLQueryField("rating", new FieldRules(false));
			RatingAmount = new GraphQLQueryField("ratingAmount", new FieldRules(false));
			UserRating = new GraphQLQueryField("userRating", new FieldRules(false));
			Score = new GraphQLQueryField("score", new FieldRules(false));
			_private = new GraphQLQueryField("_private", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			CreatedAt = new GraphQLQueryField("createdAt", new FieldRules(false));
			UpdatedAt = new GraphQLQueryField("updatedAt", new FieldRules(false));
			User = new GraphQLQueryField("user", new FieldRules(false));
			Media = new GraphQLQueryField("media", new FieldRules(false));
		}
	}
}
