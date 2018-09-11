using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available airing schedule query fields.
    /// </summary>
	public class AiringScheduleQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public AiringScheduleQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.AiringSchedule };
	    }

        /// <summary>
        /// The id of the airing schedule item
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Time the episode airs
		/// </summary>
		public GraphQueryField AiringAtQueryField()
		{
		    return new GraphQueryField("airingAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Seconds until episode starts airing
		/// </summary>
		public GraphQueryField TimeUntilAiringQueryField()
		{
		    return new GraphQueryField("timeUntilAiring", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The airing episode number
		/// </summary>
		public GraphQueryField EpisodeQueryField()
		{
		    return new GraphQueryField("episode", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The associate media id of the airing episode
		/// </summary>
		public GraphQueryField MediaIdQueryField()
		{
		    return new GraphQueryField("mediaId", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

        /// <summary>
        /// The associate media id of the airing episode
        /// </summary>
        public GraphQueryField MediaQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("media", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields, typeof(MediaQueryFields));

		    return field;
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
