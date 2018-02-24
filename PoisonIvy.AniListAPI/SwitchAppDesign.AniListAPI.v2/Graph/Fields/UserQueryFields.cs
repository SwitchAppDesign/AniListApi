using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserQueryFields
	{
		public UserQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the user
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the user
		/// </summary>
		public GraphQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// The bio written by user (Markdown)
		/// </summary>
		public GraphQueryField AboutQueryField()
		{
			return About;
		}

		/// <summary>
		/// The user's avatar images
		/// </summary>
		public GraphQueryField AvatarQueryField()
		{
			return Avatar;
		}

		/// <summary>
		/// If the authenticated user if following this user
		/// </summary>
		public GraphQueryField IsFollowingQueryField()
		{
			return IsFollowing;
		}

        /// <summary>
        /// The user's general options.
        /// </summary>
        public GraphQueryField OptionsQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Options)}) requires at least one user options query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(UserOptionsQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid user options query fields {fields.Where(x => x.ParentClassType != typeof(UserOptionsQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Options.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The user's media list options.
        /// </summary>
        public GraphQueryField MediaListOptionsQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(MediaListOptions)}) requires at least one media list options query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaListOptionsQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media list options query fields {fields.Where(x => x.ParentClassType != typeof(MediaListOptionsQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return MediaListOptions.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The users favourites.
        /// </summary>
        public GraphQueryField FavouritesQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Favourites)}) requires at least one favourites query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(FavouritesQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid favourites query fields {fields.Where(x => x.ParentClassType != typeof(FavouritesQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Favourites.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// The user's statistics.
        /// </summary>
        public GraphQueryField StatsQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Stats)}) requires at least one user stats query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(UserStatsQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid user stats query fields {fields.Where(x => x.ParentClassType != typeof(UserStatsQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Stats.GetGraphFieldAndSetFieldArguments(fields);
        }

		/// <summary>
		/// The number of unread notifications the user has
		/// </summary>
		public GraphQueryField UnreadNotificationCountQueryField()
		{
			return UnreadNotificationCount;
		}

		/// <summary>
		/// The url for the user page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// The donation tier of the user
		/// </summary>
		public GraphQueryField DonatorTierQueryField()
		{
			return DonatorTier;
		}

		/// <summary>
		/// When the user's data was last updated
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField About { get; set; }
		private GraphQueryField Avatar { get; set; }
		private GraphQueryField IsFollowing { get; set; }
		private GraphQueryField Options { get; set; }
		private GraphQueryField MediaListOptions { get; set; }
		private GraphQueryField Favourites { get; set; }
		private GraphQueryField Stats { get; set; }
		private GraphQueryField UnreadNotificationCount { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField DonatorTier { get; set; }
		private GraphQueryField UpdatedAt { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Name = new GraphQueryField("name", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			About = new GraphQueryField("about", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Avatar = new GraphQueryField("avatar", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			IsFollowing = new GraphQueryField("isFollowing", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Options = new GraphQueryField("options", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			MediaListOptions = new GraphQueryField("mediaListOptions", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Favourites = new GraphQueryField("favourites", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Stats = new GraphQueryField("stats", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			UnreadNotificationCount = new GraphQueryField("unreadNotificationCount", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			SiteUrl = new GraphQueryField("siteUrl", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			DonatorTier = new GraphQueryField("donatorTier", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			UpdatedAt = new GraphQueryField("updatedAt", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
