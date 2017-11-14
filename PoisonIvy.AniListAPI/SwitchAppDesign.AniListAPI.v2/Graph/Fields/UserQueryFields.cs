using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
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
		/// The user's general options
		/// </summary>
		public GraphQueryField OptionsQueryField()
		{
			return Options;
		}

		/// <summary>
		/// The user's media list options
		/// </summary>
		public GraphQueryField MediaListOptionsQueryField()
		{
			return MediaListOptions;
		}

		/// <summary>
		/// The users favourites
		/// </summary>
		public GraphQueryField FavouritesQueryField()
		{
			return Favourites;
		}

		public GraphQueryField StatsQueryField()
		{
			return Stats;
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
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Name = new GraphQueryField("name", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			About = new GraphQueryField("about", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Avatar = new GraphQueryField("avatar", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			IsFollowing = new GraphQueryField("isFollowing", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Options = new GraphQueryField("options", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			MediaListOptions = new GraphQueryField("mediaListOptions", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Favourites = new GraphQueryField("favourites", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Stats = new GraphQueryField("stats", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			UnreadNotificationCount = new GraphQueryField("unreadNotificationCount", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			SiteUrl = new GraphQueryField("siteUrl", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			DonatorTier = new GraphQueryField("donatorTier", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			UpdatedAt = new GraphQueryField("updatedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
