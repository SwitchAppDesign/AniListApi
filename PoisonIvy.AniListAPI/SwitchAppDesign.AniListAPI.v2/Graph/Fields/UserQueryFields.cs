using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class UserQueryFields
	{
		public UserQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the user
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the user
		/// </summary>
		public GraphQLQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// The bio written by user (Markdown)
		/// </summary>
		public GraphQLQueryField AboutQueryField()
		{
			return About;
		}

		/// <summary>
		/// The user's avatar images
		/// </summary>
		public GraphQLQueryField AvatarQueryField()
		{
			return Avatar;
		}

		/// <summary>
		/// If the authenticated user if following this user
		/// </summary>
		public GraphQLQueryField IsFollowingQueryField()
		{
			return IsFollowing;
		}

		/// <summary>
		/// The user's general options
		/// </summary>
		public GraphQLQueryField OptionsQueryField()
		{
			return Options;
		}

		/// <summary>
		/// The user's media list options
		/// </summary>
		public GraphQLQueryField MediaListOptionsQueryField()
		{
			return MediaListOptions;
		}

		/// <summary>
		/// The users favourites
		/// </summary>
		public GraphQLQueryField FavouritesQueryField()
		{
			return Favourites;
		}

		public GraphQLQueryField StatsQueryField()
		{
			return Stats;
		}

		/// <summary>
		/// The number of unread notifications the user has
		/// </summary>
		public GraphQLQueryField UnreadNotificationCountQueryField()
		{
			return UnreadNotificationCount;
		}

		/// <summary>
		/// The url for the user page on the AniList website
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// The donation tier of the user
		/// </summary>
		public GraphQLQueryField DonatorTierQueryField()
		{
			return DonatorTier;
		}

		/// <summary>
		/// When the user's data was last updated
		/// </summary>
		public GraphQLQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Name { get; set; }
		private GraphQLQueryField About { get; set; }
		private GraphQLQueryField Avatar { get; set; }
		private GraphQLQueryField IsFollowing { get; set; }
		private GraphQLQueryField Options { get; set; }
		private GraphQLQueryField MediaListOptions { get; set; }
		private GraphQLQueryField Favourites { get; set; }
		private GraphQLQueryField Stats { get; set; }
		private GraphQLQueryField UnreadNotificationCount { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField DonatorTier { get; set; }
		private GraphQLQueryField UpdatedAt { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Name = new GraphQLQueryField("name", new FieldRules(false));
			About = new GraphQLQueryField("about", new FieldRules(false));
			Avatar = new GraphQLQueryField("avatar", new FieldRules(false));
			IsFollowing = new GraphQLQueryField("isFollowing", new FieldRules(false));
			Options = new GraphQLQueryField("options", new FieldRules(false));
			MediaListOptions = new GraphQLQueryField("mediaListOptions", new FieldRules(false));
			Favourites = new GraphQLQueryField("favourites", new FieldRules(false));
			Stats = new GraphQLQueryField("stats", new FieldRules(false));
			UnreadNotificationCount = new GraphQLQueryField("unreadNotificationCount", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			DonatorTier = new GraphQLQueryField("donatorTier", new FieldRules(false));
			UpdatedAt = new GraphQLQueryField("updatedAt", new FieldRules(false));
		}
	}
}
