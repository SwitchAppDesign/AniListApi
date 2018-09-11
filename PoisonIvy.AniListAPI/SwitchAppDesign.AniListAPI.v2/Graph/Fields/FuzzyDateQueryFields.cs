using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FuzzyDateQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        public FuzzyDateQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> {AniListQueryType.Media, AniListQueryType.Page};
        }

	    /// <summary>
	    /// Year component of the date.
	    /// </summary>
	    public GraphQueryField YearQueryField()
	    {
            return new GraphQueryField("year", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

	    /// <summary>
	    /// Month component of the date.
	    /// </summary>
	    public GraphQueryField MonthQueryField()
	    {
            return new GraphQueryField("month", GetType(), _queryType, InitilizeDefaultFieldRules());
	        
        }

        /// <summary>
        /// Day component of the date.
        /// </summary>
        public GraphQueryField DayQueryField()
	    {
	        return new GraphQueryField("day", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

	    public IList<GraphQueryField> GetAllFields()
	    {
	        return new List<GraphQueryField>
	        {
	            YearQueryField(),
	            MonthQueryField(),
	            DayQueryField()
            };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
