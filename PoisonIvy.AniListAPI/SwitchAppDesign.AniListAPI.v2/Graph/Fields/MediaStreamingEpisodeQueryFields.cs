using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available streaming episode query fields.
    /// </summary>
	public class MediaStreamingEpisodeQueryFields
	{
		internal MediaStreamingEpisodeQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// Title of the episode
		/// </summary>
		public GraphQueryField TitleQueryField()
		{
			return Title;
		}

		/// <summary>
		/// Url of episode image thumbnail
		/// </summary>
		public GraphQueryField ThumbnailQueryField()
		{
			return Thumbnail;
		}

		/// <summary>
		/// The url of the episode
		/// </summary>
		public GraphQueryField UrlQueryField()
		{
			return Url;
		}

		/// <summary>
		/// The site location of the streaming episodes
		/// </summary>
		public GraphQueryField SiteQueryField()
		{
			return Site;
		}

		private GraphQueryField Title { get; set; }
		private GraphQueryField Thumbnail { get; set; }
		private GraphQueryField Url { get; set; }
		private GraphQueryField Site { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Title = new GraphQueryField("title", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			Thumbnail = new GraphQueryField("thumbnail", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			Url = new GraphQueryField("url", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			Site = new GraphQueryField("site", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
		}
	}
}
