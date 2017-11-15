using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media external link query fields.
    /// </summary>
    public class MediaExternalLinkQueryFields
	{
		internal MediaExternalLinkQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the external link
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The url of the external link
		/// </summary>
		public GraphQueryField UrlQueryField()
		{
			return Url;
		}

		/// <summary>
		/// The site location of the external link
		/// </summary>
		public GraphQueryField SiteQueryField()
		{
			return Site;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Url { get; set; }
		private GraphQueryField Site { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Url = new GraphQueryField("url", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Site = new GraphQueryField("site", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
		}
	}
}
