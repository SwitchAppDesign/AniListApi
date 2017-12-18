using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    /// <summary>
    /// All pre-built queries.
    /// </summary>
    public partial class PreBuiltPageQueries
    {
        private PageQueryBuilder _builder;

        internal PreBuiltPageQueries()
        {
        }

        internal GraphQuery BasicAnimeMediaQuery(string searchPhrase)
        {
            _builder = new PageQueryBuilder();

            //_builder.AddArgument(_builder.MediaQueryArguments.IdQueryArgument(anilistMediaId));
            //_builder.AddArgument(_builder.MediaQueryArguments.TypeArgument(MediaType.Anime));

            BasicAnimeFields();

            return _builder.BuildQuery();
        }

        internal GraphQuery FullAnimeQuery(string searchPhrase)
        {
            _builder = new PageQueryBuilder();

            //_builder.AddArgument(_builder.MediaQueryArguments.IdQueryArgument(anilistMediaId));
            //_builder.AddArgument(_builder.MediaQueryArguments.TypeArgument(MediaType.Anime));

            //FullAnimeFields();

            return _builder.BuildQuery();
        }
    }
}