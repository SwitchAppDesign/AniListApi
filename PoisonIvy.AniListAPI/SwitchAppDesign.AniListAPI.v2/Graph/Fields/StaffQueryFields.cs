using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available staff query fields.
    /// </summary>
	public class StaffQueryFields
	{
		internal StaffQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the staff member
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The names of the staff member
		/// </summary>
		public GraphQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// The primary language of the staff member
		/// </summary>
		public GraphQueryField LanguageQueryField()
		{
			return Language;
		}

		/// <summary>
		/// The staff images
		/// </summary>
		public GraphQueryField ImageQueryField()
		{
			return Image;
		}

		/// <summary>
		/// A general description of the staff member
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// If the staff member is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// The url for the staff page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// Media where the staff member has a production role
		/// </summary>
		public GraphQueryField StaffMediaQueryField()
		{
			return StaffMedia;
		}

		/// <summary>
		/// Characters voiced by the actor
		/// </summary>
		public GraphQueryField CharactersQueryField()
		{
			return Characters;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField Language { get; set; }
		private GraphQueryField Image { get; set; }
		private GraphQueryField Description { get; set; }
		private GraphQueryField IsFavourite { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField StaffMedia { get; set; }
		private GraphQueryField Characters { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Name = new GraphQueryField("name", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Language = new GraphQueryField("language", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Image = new GraphQueryField("image", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Description = new GraphQueryField("description", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			IsFavourite = new GraphQueryField("isFavourite", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			SiteUrl = new GraphQueryField("siteUrl", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			StaffMedia = new GraphQueryField("staffMedia", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Characters = new GraphQueryField("characters", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
		}
	}
}
