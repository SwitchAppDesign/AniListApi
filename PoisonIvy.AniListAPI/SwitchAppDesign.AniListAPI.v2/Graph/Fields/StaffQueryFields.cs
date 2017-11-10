using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class Staff
    {
        public Staff()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the staff member
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The names of the staff member
        /// </summary>
        public GraphQLQueryField NameQueryField { get; private set; }

        /// <summary>
        /// The primary language of the staff member
        /// </summary>
        public GraphQLQueryField LanguageQueryField { get; private set; }

        /// <summary>
        /// The staff images
        /// </summary>
        public GraphQLQueryField ImageQueryField { get; private set; }

        /// <summary>
        /// A general description of the staff member
        /// </summary>
        public GraphQLQueryField DescriptionQueryField { get; private set; }

        /// <summary>
        /// If the staff member is marked as favourite by the currently authenticated user
        /// </summary>
        public GraphQLQueryField IsFavouriteQueryField { get; private set; }

        /// <summary>
        /// The url for the staff page on the AniList website
        /// </summary>
        public GraphQLQueryField SiteUrlQueryField { get; private set; }

        /// <summary>
        /// Media where the staff member has a production role
        /// </summary>
        public GraphQLQueryField StaffMediaQueryField { get; private set; }

        /// <summary>
        /// Characters voiced by the actor
        /// </summary>
        public GraphQLQueryField CharactersQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            NameQueryField = new GraphQLQueryField("name", new FieldRules(false));
            LanguageQueryField = new GraphQLQueryField("language", new FieldRules(false));
            ImageQueryField = new GraphQLQueryField("image", new FieldRules(false));
            DescriptionQueryField = new GraphQLQueryField("description", new FieldRules(false));
            IsFavouriteQueryField = new GraphQLQueryField("isFavourite", new FieldRules(false));
            SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
            StaffMediaQueryField = new GraphQLQueryField("staffMedia", new FieldRules(false));
            CharactersQueryField = new GraphQLQueryField("characters", new FieldRules(false));
        }
    }
}
