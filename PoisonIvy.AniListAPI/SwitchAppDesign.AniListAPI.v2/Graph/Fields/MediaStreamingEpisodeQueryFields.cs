using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaStreamingEpisodeQueryFields
	{
		public MediaStreamingEpisodeQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// Title of the episode
		/// </summary>
		public GraphQLQueryField TitleQueryField()
		{
			return Title;
		}

		/// <summary>
		/// Url of episode image thumbnail
		/// </summary>
		public GraphQLQueryField ThumbnailQueryField()
		{
			return Thumbnail;
		}

		/// <summary>
		/// The url of the episode
		/// </summary>
		public GraphQLQueryField UrlQueryField()
		{
			return Url;
		}

		/// <summary>
		/// The site location of the streaming episodes
		/// </summary>
		public GraphQLQueryField SiteQueryField()
		{
			return Site;
		}

		private GraphQLQueryField Title { get; set; }
		private GraphQLQueryField Thumbnail { get; set; }
		private GraphQLQueryField Url { get; set; }
		private GraphQLQueryField Site { get; set; }

		private void InitializeProperties()
		{
			Title = new GraphQLQueryField("title", new FieldRules(false));
			Thumbnail = new GraphQLQueryField("thumbnail", new FieldRules(false));
			Url = new GraphQLQueryField("url", new FieldRules(false));
			Site = new GraphQLQueryField("site", new FieldRules(false));
		}
	}
}
