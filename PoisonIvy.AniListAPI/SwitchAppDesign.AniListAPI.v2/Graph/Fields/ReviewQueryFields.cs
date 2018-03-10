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
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public ReviewQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Review };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The id of the review
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the review's creator
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
		    return new GraphQueryField("userId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the review's media
		/// </summary>
		public GraphQueryField MediaIdQueryField()
		{
		    return new GraphQueryField("mediaId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// For which type of media the review is for
		/// </summary>
		public GraphQueryField MediaTypeQueryField()
		{
		    return new GraphQueryField("mediaType", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// A short summary of the review
		/// </summary>
		public GraphQueryField SummaryQueryField()
		{
		    return new GraphQueryField("summary", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The main review body text
		/// </summary>
		public GraphQueryField BodyQueryField()
		{
		    return new GraphQueryField("body", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The total user rating of the review
		/// </summary>
		public GraphQueryField RatingQueryField()
		{
		    return new GraphQueryField("rating", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The amount of user ratings of the review
		/// </summary>
		public GraphQueryField RatingAmountQueryField()
		{
		    return new GraphQueryField("ratingAmount", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The rating of the review by currently authenticated user
		/// </summary>
		public GraphQueryField UserRatingQueryField()
		{
		    return new GraphQueryField("userRating", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The review score of the media
		/// </summary>
		public GraphQueryField ScoreQueryField()
		{
		    return new GraphQueryField("score", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the review is not yet publicly published and is only viewable by creator
		/// </summary>
		public GraphQueryField _privateQueryField()
		{
		    return new GraphQueryField("_private", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The url for the review page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
		    return new GraphQueryField("siteUrl", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The time of the thread creation
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
		    return new GraphQueryField("createdAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The time of the thread last update
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
		    return new GraphQueryField("updatedAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The id of the review's creator.
        /// <param name="fields">The list of user query fields (found in <see cref="UserQueryFields"/>) to be used in the graph query (at least of user query field is required).</param>
        /// </summary>
        public GraphQueryField UserQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("user", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(UserQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(UserQueryFields));
            
		    return field;
        }

        /// <summary>
        /// The id of the review's media
        /// <param name="fields">The list of media query fields (found in <see cref="MediaQueryFields"/>) to be used in the graph query (at least of media query field is required).</param>
        /// </summary>
        public GraphQueryField MediaQueryField(IList<GraphQueryField> fields)
        {
		    var field = new GraphQueryField("media", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(MediaQueryFields));

            return field;
        }
	}
}
