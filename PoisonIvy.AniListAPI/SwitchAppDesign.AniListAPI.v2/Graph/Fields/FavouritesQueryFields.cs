using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FavouritesQueryFields
	{
		public FavouritesQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of media connection fields (found in <see cref="MediaConnectionQueryFields"/>) to be used in the graph query (at least of media connection query field is required).</param>
        /// </summary>
        public GraphQueryField AnimeQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Anime.GetType().Name}) requires at least one media connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media connection query fields {fields.Where(x => x.ParentClassType != typeof(MediaConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Anime.GetGraphFieldAndSetFieldArguments(fields);
        }

	    /// <summary>
	    /// <param name="fields">The list of media connection fields (found in <see cref="MediaListOptionsQueryFields"/>) to be used in the graph query (at least of media connection query field is required).</param>
	    /// </summary>
        public GraphQueryField MangaQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Manga.GetType().Name}) requires at least one media connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media connection query fields {fields.Where(x => x.ParentClassType != typeof(MediaConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Manga.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of character connection fields (found in <see cref="CharacterConnectionQueryFields"/>) to be used in the graph query (at least of character connection query field is required).</param>
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Characters.GetType().Name}) requires at least one character connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(CharacterConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid character connection query fields {fields.Where(x => x.ParentClassType != typeof(CharacterConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Characters.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of staff connection fields (found in <see cref="StaffConnectionQueryFields"/>) to be used in the graph query (at least of staff connection query field is required).</param>
        /// </summary>
        public GraphQueryField StaffQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Staff.GetType().Name}) requires at least one staff connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StaffConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid staff connection query fields {fields.Where(x => x.ParentClassType != typeof(StaffConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Staff.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of staff connection fields (found in <see cref="StaffConnectionQueryFields"/>) to be used in the graph query (at least of staff connection query field is required).</param>
        /// </summary>
        public GraphQueryField StudiosQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Studios.GetType().Name}) requires at least one staff connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StaffConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid staff connection query fields {fields.Where(x => x.ParentClassType != typeof(StaffConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Studios.GetGraphFieldAndSetFieldArguments(fields);
        }

		private GraphQueryField Anime { get; set; }
		private GraphQueryField Manga { get; set; }
		private GraphQueryField Characters { get; set; }
		private GraphQueryField Staff { get; set; }
		private GraphQueryField Studios { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Anime = new GraphQueryField("anime", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Manga = new GraphQueryField("manga", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Characters = new GraphQueryField("characters", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Staff = new GraphQueryField("staff", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Studios = new GraphQueryField("studios", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
