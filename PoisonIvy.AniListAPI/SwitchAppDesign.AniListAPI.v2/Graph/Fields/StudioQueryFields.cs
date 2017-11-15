using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All Available studio query fields.
    /// </summary>
	public class StudioQueryFields
	{
		internal StudioQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the studio
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the studio
		/// </summary>
		public GraphQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// The media the studio has worked on
		/// </summary>
		public GraphQueryField MediaQueryField()
		{
			return Media;
		}

		/// <summary>
		/// The url for the studio page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// If the studio is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField Media { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField IsFavourite { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			Name = new GraphQueryField("name", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			Media = new GraphQueryField("media", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			SiteUrl = new GraphQueryField("siteUrl", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			IsFavourite = new GraphQueryField("isFavourite", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
		}
	}
}
