using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaListOptionsQueryFields
	{
		public MediaListOptionsQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField ScoreFormatQueryField()
		{
			return ScoreFormat;
		}

		public GraphQLQueryField RowOrderQueryField()
		{
			return RowOrder;
		}

		public GraphQLQueryField UseLegacyListsQueryField()
		{
			return UseLegacyLists;
		}

		public GraphQLQueryField AnimeListQueryField()
		{
			return AnimeList;
		}

		public GraphQLQueryField MangaListQueryField()
		{
			return MangaList;
		}

		private GraphQLQueryField ScoreFormat { get; set; }
		private GraphQLQueryField RowOrder { get; set; }
		private GraphQLQueryField UseLegacyLists { get; set; }
		private GraphQLQueryField AnimeList { get; set; }
		private GraphQLQueryField MangaList { get; set; }

		private void InitializeProperties()
		{
			ScoreFormat = new GraphQLQueryField("scoreFormat", new FieldRules(false));
			RowOrder = new GraphQLQueryField("rowOrder", new FieldRules(false));
			UseLegacyLists = new GraphQLQueryField("useLegacyLists", new FieldRules(false));
			AnimeList = new GraphQLQueryField("animeList", new FieldRules(false));
			MangaList = new GraphQLQueryField("mangaList", new FieldRules(false));
		}
	}
}
