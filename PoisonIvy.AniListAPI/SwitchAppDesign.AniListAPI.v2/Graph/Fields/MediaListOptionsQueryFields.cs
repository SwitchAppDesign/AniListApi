using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaListOptionsQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        public MediaListOptionsQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType>
            {
                AniListQueryType.MediaList
            };

        }

        /// <summary>
        /// The score format the user is using for media lists
        /// </summary>
        public GraphQueryField ScoreFormatQueryField()
		{
		    return new GraphQueryField("scoreFormat", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The default order list rows should be displayed in
        /// </summary>
        public GraphQueryField RowOrderQueryField()
		{
		    return new GraphQueryField("rowOrder", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// (Site only) If the user should be using legacy css-supporting list versions
        /// </summary>
		public GraphQueryField UseLegacyListsQueryField()
		{
		    return new GraphQueryField("useLegacyLists", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The user's anime list options.
        /// </summary>
        public GraphQueryField AnimeListQueryField(IList<GraphQueryField> fields)
		{
            var field = new GraphQueryField("animeList", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaListOptionsQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(MediaListOptionsQueryFields));

            return field;
        }

	    /// <summary>
	    /// The user's manga list options.
	    /// </summary>
        public GraphQueryField MangaListQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("mangaList", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaListOptionsQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(MediaListOptionsQueryFields));

            return field;
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
