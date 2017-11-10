using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaListOptions
    {
        public MediaListOptions()
        {
            InitializeProperties();
        }

        public GraphQLQueryField ScoreFormatQueryField { get; private set; }

        public GraphQLQueryField RowOrderQueryField { get; private set; }

        public GraphQLQueryField UseLegacyListsQueryField { get; private set; }

        public GraphQLQueryField AnimeListQueryField { get; private set; }

        public GraphQLQueryField MangaListQueryField { get; private set; }

        private void InitializeProperties()
        {
            ScoreFormatQueryField = new GraphQLQueryField("scoreFormat", new FieldRules(false));
            RowOrderQueryField = new GraphQLQueryField("rowOrder", new FieldRules(false));
            UseLegacyListsQueryField = new GraphQLQueryField("useLegacyLists", new FieldRules(false));
            AnimeListQueryField = new GraphQLQueryField("animeList", new FieldRules(false));
            MangaListQueryField = new GraphQLQueryField("mangaList", new FieldRules(false));
        }
    }
}
