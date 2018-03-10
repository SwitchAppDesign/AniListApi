using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public UserQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.User };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The id of the user
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The name of the user
		/// </summary>
		public GraphQueryField NameQueryField()
		{
		    return new GraphQueryField("name", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The bio written by user (Markdown)
		/// </summary>
		public GraphQueryField AboutQueryField()
		{
		    return new GraphQueryField("about", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The user's avatar images
		/// </summary>
		public GraphQueryField AvatarQueryField()
		{
		    return new GraphQueryField("avatar", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the authenticated user if following this user
		/// </summary>
		public GraphQueryField IsFollowingQueryField()
		{
		    return new GraphQueryField("isFollowing", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The user's general options.
        /// </summary>
        public GraphQueryField OptionsQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("options", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(UserOptionsQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(UserOptionsQueryFields));

		    return field;
        }

        /// <summary>
        /// The user's media list options.
        /// </summary>
        public GraphQueryField MediaListOptionsQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("mediaListOptions", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaListOptionsQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(MediaListOptionsQueryFields));

            return field;
        }

        /// <summary>
        /// The users favourites.
        /// </summary>
        public GraphQueryField FavouritesQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("favourites", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(FavouritesQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(FavouritesQueryFields));

            return field;
        }

        /// <summary>
        /// The user's statistics.
        /// </summary>
        public GraphQueryField StatsQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("stats", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(UserStatsQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(UserStatsQueryFields));

            return field;
        }

		/// <summary>
		/// The number of unread notifications the user has
		/// </summary>
		public GraphQueryField UnreadNotificationCountQueryField()
		{
		    return new GraphQueryField("unreadNotificationCount", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The url for the user page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
		    return new GraphQueryField("siteUrl", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The donation tier of the user
		/// </summary>
		public GraphQueryField DonatorTierQueryField()
		{
		    return new GraphQueryField("donatorTier", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// When the user's data was last updated
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
			return new GraphQueryField("updatedAt", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
