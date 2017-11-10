using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class User
    {
        public User()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the user
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        public GraphQLQueryField NameQueryField { get; private set; }

        /// <summary>
        /// The bio written by user (Markdown)
        /// </summary>
        public GraphQLQueryField AboutQueryField { get; private set; }

        /// <summary>
        /// The user's avatar images
        /// </summary>
        public GraphQLQueryField AvatarQueryField { get; private set; }

        /// <summary>
        /// If the authenticated user if following this user
        /// </summary>
        public GraphQLQueryField IsFollowingQueryField { get; private set; }

        /// <summary>
        /// The user's general options
        /// </summary>
        public GraphQLQueryField OptionsQueryField { get; private set; }

        /// <summary>
        /// The user's media list options
        /// </summary>
        public GraphQLQueryField MediaListOptionsQueryField { get; private set; }

        /// <summary>
        /// The users favourites
        /// </summary>
        public GraphQLQueryField FavouritesQueryField { get; private set; }

        public GraphQLQueryField StatsQueryField { get; private set; }

        /// <summary>
        /// The number of unread notifications the user has
        /// </summary>
        public GraphQLQueryField UnreadNotificationCountQueryField { get; private set; }

        /// <summary>
        /// The url for the user page on the AniList website
        /// </summary>
        public GraphQLQueryField SiteUrlQueryField { get; private set; }

        /// <summary>
        /// The donation tier of the user
        /// </summary>
        public GraphQLQueryField DonatorTierQueryField { get; private set; }

        /// <summary>
        /// When the user's data was last updated
        /// </summary>
        public GraphQLQueryField UpdatedAtQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            NameQueryField = new GraphQLQueryField("name", new FieldRules(false));
            AboutQueryField = new GraphQLQueryField("about", new FieldRules(false));
            AvatarQueryField = new GraphQLQueryField("avatar", new FieldRules(false));
            IsFollowingQueryField = new GraphQLQueryField("isFollowing", new FieldRules(false));
            OptionsQueryField = new GraphQLQueryField("options", new FieldRules(false));
            MediaListOptionsQueryField = new GraphQLQueryField("mediaListOptions", new FieldRules(false));
            FavouritesQueryField = new GraphQLQueryField("favourites", new FieldRules(false));
            StatsQueryField = new GraphQLQueryField("stats", new FieldRules(false));
            UnreadNotificationCountQueryField = new GraphQLQueryField("unreadNotificationCount", new FieldRules(false));
            SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
            DonatorTierQueryField = new GraphQLQueryField("donatorTier", new FieldRules(false));
            UpdatedAtQueryField = new GraphQLQueryField("updatedAt", new FieldRules(false));
        }
    }
}
