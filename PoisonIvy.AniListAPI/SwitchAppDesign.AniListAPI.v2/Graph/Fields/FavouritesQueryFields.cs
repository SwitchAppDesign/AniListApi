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

        public GraphQueryField AnimeQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("anime", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
        }

        public GraphQueryField MangaQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("manga", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("characters", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(CharacterConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
		}

        public GraphQueryField StaffQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("staff", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StaffConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field.GetGraphFieldAndSetFieldArguments(fields);
        }

        public GraphQueryField StudiosQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("studios", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StudioConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
