using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FavouritesQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        public FavouritesQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> {AniListQueryType.User};
        }

        /// <summary>
        /// <param name="fields">The list of media connection fields (found in <see cref="MediaConnectionQueryFields"/>) to be used in the graph query (at least of media connection query field is required).</param>
        /// </summary>
        public GraphQueryField AnimeQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("anime", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
        }

	    /// <summary>
	    /// <param name="fields">The list of media connection fields (found in <see cref="MediaListOptionsQueryFields"/>) to be used in the graph query (at least of media connection query field is required).</param>
	    /// </summary>
        public GraphQueryField MangaQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("manga", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        /// <summary>
        /// <param name="fields">The list of character connection fields (found in <see cref="CharacterConnectionQueryFields"/>) to be used in the graph query (at least of character connection query field is required).</param>
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("characters", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
		}

        /// <summary>
        /// <param name="fields">The list of staff connection fields (found in <see cref="StaffConnectionQueryFields"/>) to be used in the graph query (at least of staff connection query field is required).</param>
        /// </summary>
        public GraphQueryField StaffQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("staff", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// <param name="fields">The list of staff connection fields (found in <see cref="StaffConnectionQueryFields"/>) to be used in the graph query (at least of staff connection query field is required).</param>
        /// </summary>
        public GraphQueryField StudiosQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("studios", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
