using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaListOptionsQueryFields
	{
		public MediaListOptionsQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField ScoreFormatQueryField()
		{
			return ScoreFormat;
		}

		public GraphQueryField RowOrderQueryField()
		{
			return RowOrder;
		}

		public GraphQueryField UseLegacyListsQueryField()
		{
			return UseLegacyLists;
		}

		public GraphQueryField AnimeListQueryField()
		{
			return AnimeList;
		}

		public GraphQueryField MangaListQueryField()
		{
			return MangaList;
		}

		private GraphQueryField ScoreFormat { get; set; }
		private GraphQueryField RowOrder { get; set; }
		private GraphQueryField UseLegacyLists { get; set; }
		private GraphQueryField AnimeList { get; set; }
		private GraphQueryField MangaList { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			ScoreFormat = new GraphQueryField("scoreFormat", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			RowOrder = new GraphQueryField("rowOrder", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			UseLegacyLists = new GraphQueryField("useLegacyLists", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			AnimeList = new GraphQueryField("animeList", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			MangaList = new GraphQueryField("mangaList", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
		}
	}
}
