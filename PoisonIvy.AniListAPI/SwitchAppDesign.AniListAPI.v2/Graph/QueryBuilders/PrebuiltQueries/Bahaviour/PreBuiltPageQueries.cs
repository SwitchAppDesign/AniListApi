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

        internal GraphQuery BasicAnimeMediaQuery(string searchPhrase, int pageNumber, int pageSize)
        {
            _builder = new PageQueryBuilder();

            _builder.AddArgument(_builder.PageQueryArguments.PageQueryArgument(pageNumber));
            _builder.AddArgument(_builder.PageQueryArguments.PerPageQueryArgument(pageNumber));

            BasicAnimeFields(searchPhrase);

            return _builder.BuildQuery();
        }

        internal GraphQuery FullAnimeQuery(string searchPhrase, int pageNumber, int pageSize)
        {
            _builder = new PageQueryBuilder();

            _builder.AddArgument(_builder.PageQueryArguments.PageQueryArgument(pageNumber));
            _builder.AddArgument(_builder.PageQueryArguments.PerPageQueryArgument(pageNumber));

            FullAnimeFields();

            return _builder.BuildQuery();
        }
    }
}