using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class CharacterQueryFields
	{
		public CharacterQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the character
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The names of the character
		/// </summary>
		public GraphQLQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// Character images
		/// </summary>
		public GraphQLQueryField ImageQueryField()
		{
			return Image;
		}

		/// <summary>
		/// A general description of the character
		/// </summary>
		public GraphQLQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// If the character is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQLQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// The url for the character page on the AniList website
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// Media that includes the character
		/// </summary>
		public GraphQLQueryField MediaQueryField()
		{
			return Media;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Name { get; set; }
		private GraphQLQueryField Image { get; set; }
		private GraphQLQueryField Description { get; set; }
		private GraphQLQueryField IsFavourite { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField Media { get; set; }
       
		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Name = new GraphQLQueryField("name", new FieldRules(false));
			Image = new GraphQLQueryField("image", new FieldRules(false));
			Description = new GraphQLQueryField("description", new FieldRules(false));
			IsFavourite = new GraphQLQueryField("isFavourite", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			Media = new GraphQLQueryField("media", new FieldRules(false));
		}
	}
}
