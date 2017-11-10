using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class Studio
    {
        public Studio()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the studio
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The name of the studio
        /// </summary>
        public GraphQLQueryField NameQueryField { get; private set; }

        /// <summary>
        /// The media the studio has worked on
        /// </summary>
        public GraphQLQueryField MediaQueryField { get; private set; }

        /// <summary>
        /// The url for the studio page on the AniList website
        /// </summary>
        public GraphQLQueryField SiteUrlQueryField { get; private set; }

        /// <summary>
        /// If the studio is marked as favourite by the currently authenticated user
        /// </summary>
        public GraphQLQueryField IsFavouriteQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            NameQueryField = new GraphQLQueryField("name", new FieldRules(false));
            MediaQueryField = new GraphQLQueryField("media", new FieldRules(false));
            SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
            IsFavouriteQueryField = new GraphQLQueryField("isFavourite", new FieldRules(false));
        }
    }
}
