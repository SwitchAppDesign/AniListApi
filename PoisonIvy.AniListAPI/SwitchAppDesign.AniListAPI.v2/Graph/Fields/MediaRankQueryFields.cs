using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media rank query fields.
    /// </summary>
	public class MediaRankQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public MediaRankQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The id of the rank
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The numerical rank of the media
		/// </summary>
		public GraphQueryField RankQueryField()
		{
		    return new GraphQueryField("rank", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The type of ranking
		/// </summary>
		public GraphQueryField TypeQueryField()
		{
		    return new GraphQueryField("type", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The format the media is ranked within
		/// </summary>
		public GraphQueryField FormatQueryField()
		{
			return new GraphQueryField("format", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The year the media is ranked within
		/// </summary>
		public GraphQueryField YearQueryField()
		{
		    return new GraphQueryField("year", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The season the media is ranked within
		/// </summary>
		public GraphQueryField SeasonQueryField()
		{
		    return new GraphQueryField("season", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the ranking is based on all time instead of a season/year
		/// </summary>
		public GraphQueryField AllTimeQueryField()
		{
		    return new GraphQueryField("allTime", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// String that gives context to the ranking type and time span
		/// </summary>
		public GraphQueryField ContextQueryField()
		{
			return new GraphQueryField("context", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
