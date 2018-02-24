using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FuzzyDateQueryFields
	{
		public FuzzyDateQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

	    /// <summary>
	    /// Year component of the date.
	    /// </summary>
	    public GraphQueryField YearQueryField()
	    {
	        return Year;
	    }

	    /// <summary>
	    /// Month component of the date.
	    /// </summary>
	    public GraphQueryField MonthQueryField()
	    {
	        return Month;
	    }

        /// <summary>
        /// Day component of the date.
        /// </summary>
        public GraphQueryField DayQueryField()
	    {
	        return Day;
	    }

	    public IList<GraphQueryField> GetAllFields()
	    {
	        return new List<GraphQueryField>
	        {
	            Year,
	            Month,
                Day
            };
	    }

        private GraphQueryField Year { get; set; }
	    private GraphQueryField Month { get; set; }
	    private GraphQueryField Day { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
		{
		    Year = new GraphQueryField("year", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
		    Month = new GraphQueryField("month", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
		    Day = new GraphQueryField("day", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
        }
    }
}
