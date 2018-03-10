using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available streaming episode query fields.
    /// </summary>
	public class MediaStreamingEpisodeQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public MediaStreamingEpisodeQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// Title of the episode
        /// </summary>
        public GraphQueryField TitleQueryField()
		{
		    return new GraphQueryField("title", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Url of episode image thumbnail
		/// </summary>
		public GraphQueryField ThumbnailQueryField()
		{
		    return new GraphQueryField("thumbnail", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The url of the episode
		/// </summary>
		public GraphQueryField UrlQueryField()
		{
		    return new GraphQueryField("url", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// The site location of the streaming episodes
		/// </summary>
		public GraphQueryField SiteQueryField()
		{
			return new GraphQueryField("site", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
