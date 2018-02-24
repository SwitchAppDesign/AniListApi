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
		public MediaListOptionsQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// The score format the user is using for media lists
        /// </summary>
        public GraphQueryField ScoreFormatQueryField()
		{
			return ScoreFormat;
		}

        /// <summary>
        /// The default order list rows should be displayed in
        /// </summary>
        public GraphQueryField RowOrderQueryField()
		{
			return RowOrder;
		}

        /// <summary>
        /// (Site only) If the user should be using legacy css-supporting list versions
        /// </summary>
		public GraphQueryField UseLegacyListsQueryField()
		{
			return UseLegacyLists;
		}

        /// <summary>
        /// The user's anime list options.
        /// </summary>
        public GraphQueryField AnimeListQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(AnimeList)}) requires at least one user options query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaListTypeOptionsQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid user options query fields {fields.Where(x => x.ParentClassType != typeof(MediaListTypeOptionsQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return AnimeList.GetGraphFieldAndSetFieldArguments(fields);
        }

	    /// <summary>
	    /// The user's manga list options.
	    /// </summary>
        public GraphQueryField MangaListQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(MangaList)}) requires at least one user options query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaListTypeOptionsQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid user options query fields {fields.Where(x => x.ParentClassType != typeof(MediaListTypeOptionsQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return MangaList.GetGraphFieldAndSetFieldArguments(fields);
        }

		private GraphQueryField ScoreFormat { get; set; }
		private GraphQueryField RowOrder { get; set; }
		private GraphQueryField UseLegacyLists { get; set; }
		private GraphQueryField AnimeList { get; set; }
		private GraphQueryField MangaList { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			ScoreFormat = new GraphQueryField("scoreFormat", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			RowOrder = new GraphQueryField("rowOrder", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			UseLegacyLists = new GraphQueryField("useLegacyLists", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			AnimeList = new GraphQueryField("animeList", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			MangaList = new GraphQueryField("mangaList", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
		}
	}
}
