using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available character query fields.
    /// </summary>
	public class CharacterQueryFields
	{
		internal CharacterQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the character
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The names of the character
		/// </summary>
		public GraphQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// Character images
		/// </summary>
		public GraphQueryField ImageQueryField()
		{
			return Image;
		}

		/// <summary>
		/// A general description of the character
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// If the character is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// The url for the character page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// Media that includes the character
		/// </summary>
		public GraphQueryField MediaQueryField()
		{
			return Media;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField Image { get; set; }
		private GraphQueryField Description { get; set; }
		private GraphQueryField IsFavourite { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField Media { get; set; }
       
		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));
			Name = new GraphQueryField("name", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));
			Image = new GraphQueryField("image", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));
			Description = new GraphQueryField("description", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));
			IsFavourite = new GraphQueryField("isFavourite", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));
			SiteUrl = new GraphQueryField("siteUrl", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));
			Media = new GraphQueryField("media", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media }));
		}
	}
}
