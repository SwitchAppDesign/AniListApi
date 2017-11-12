using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StudioQueryFields
	{
		public StudioQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the studio
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the studio
		/// </summary>
		public GraphQLQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// The media the studio has worked on
		/// </summary>
		public GraphQLQueryField MediaQueryField()
		{
			return Media;
		}

		/// <summary>
		/// The url for the studio page on the AniList website
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// If the studio is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQLQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Name { get; set; }
		private GraphQLQueryField Media { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField IsFavourite { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Name = new GraphQLQueryField("name", new FieldRules(false));
			Media = new GraphQLQueryField("media", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			IsFavourite = new GraphQLQueryField("isFavourite", new FieldRules(false));
		}
	}
}
