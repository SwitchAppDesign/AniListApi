using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class AiringProgressionQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public AiringProgressionQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

        /// <summary>
        /// The episode the stats were recorded at. .5 is the mid point between 2 episodes airing dates.
        /// </summary>
        public GraphQueryField EpisodeQueryField()
		{
		    return new GraphQueryField("episode", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The average score for the media
		/// </summary>
		public GraphQueryField ScoreQueryField()
		{
		    return new GraphQueryField("score", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

		/// <summary>
		/// The amount of users watching the anime
		/// </summary>
		public GraphQueryField WatchingQueryField()
		{
			return new GraphQueryField("watching", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
