using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class StaffQueryFields
	{
		public StaffQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the staff member
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The names of the staff member
		/// </summary>
		public GraphQLQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// The primary language of the staff member
		/// </summary>
		public GraphQLQueryField LanguageQueryField()
		{
			return Language;
		}

		/// <summary>
		/// The staff images
		/// </summary>
		public GraphQLQueryField ImageQueryField()
		{
			return Image;
		}

		/// <summary>
		/// A general description of the staff member
		/// </summary>
		public GraphQLQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// If the staff member is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQLQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// The url for the staff page on the AniList website
		/// </summary>
		public GraphQLQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// Media where the staff member has a production role
		/// </summary>
		public GraphQLQueryField StaffMediaQueryField()
		{
			return StaffMedia;
		}

		/// <summary>
		/// Characters voiced by the actor
		/// </summary>
		public GraphQLQueryField CharactersQueryField()
		{
			return Characters;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Name { get; set; }
		private GraphQLQueryField Language { get; set; }
		private GraphQLQueryField Image { get; set; }
		private GraphQLQueryField Description { get; set; }
		private GraphQLQueryField IsFavourite { get; set; }
		private GraphQLQueryField SiteUrl { get; set; }
		private GraphQLQueryField StaffMedia { get; set; }
		private GraphQLQueryField Characters { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Name = new GraphQLQueryField("name", new FieldRules(false));
			Language = new GraphQLQueryField("language", new FieldRules(false));
			Image = new GraphQLQueryField("image", new FieldRules(false));
			Description = new GraphQLQueryField("description", new FieldRules(false));
			IsFavourite = new GraphQLQueryField("isFavourite", new FieldRules(false));
			SiteUrl = new GraphQLQueryField("siteUrl", new FieldRules(false));
			StaffMedia = new GraphQLQueryField("staffMedia", new FieldRules(false));
			Characters = new GraphQLQueryField("characters", new FieldRules(false));
		}
	}
}
