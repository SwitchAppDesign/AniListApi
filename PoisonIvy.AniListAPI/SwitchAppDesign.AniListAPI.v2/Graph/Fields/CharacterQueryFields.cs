using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class Character
	{
		public Character()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the character
		/// </summary>
		public GraphQLQueryField IdQueryField { get; private set; }

		/// <summary>
		/// The names of the character
		/// </summary>
		public GraphQLQueryField NameQueryField { get; private set; }

		/// <summary>
		/// Character images
		/// </summary>
		public GraphQLQueryField ImageQueryField { get; private set; }

		/// <summary>
		/// A general description of the character
		/// </summary>
		public GraphQLQueryField DescriptionQueryField { get; private set; }

		/// <summary>
		/// If the character is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQLQueryField IsFavouriteQueryField { get; private set; }

		/// <summary>
		/// The url for the character page on the AniList website
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField { get; private set; }

		/// <summary>
		/// Media that includes the character
		/// </summary>
		public GraphQLQueryField MediaQueryField { get; private set; }

		private void InitializeProperties()
		{
			IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
			NameQueryField = new GraphQLQueryField("name", new FieldRules(false));
			ImageQueryField = new GraphQLQueryField("image", new FieldRules(false));
			DescriptionQueryField = new GraphQLQueryField("description", new FieldRules(false));
			IsFavouriteQueryField = new GraphQLQueryField("isFavourite", new FieldRules(false));
			SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
			MediaQueryField = new GraphQLQueryField("media", new FieldRules(false));
		}
	}
}
