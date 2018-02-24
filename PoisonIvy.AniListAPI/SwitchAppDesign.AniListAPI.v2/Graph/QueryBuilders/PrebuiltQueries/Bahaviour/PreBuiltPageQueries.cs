using SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.Builders;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.QueryBuilders.PrebuiltQueries
{
    /// <summary>
    /// All pre-built queries for page.
    /// </summary>
    public partial class PreBuiltPageQueries
    {
        private PageQueryBuilder _builder;

        internal PreBuiltPageQueries()
        {
            
        }

        internal GraphQuery SearchFullAnimeQuery(string searchPhrase)
        {
            _builder = new PageQueryBuilder();
            
            FullAnimeFields(searchPhrase);

            return _builder.BuildQuery();
        }
    }
}