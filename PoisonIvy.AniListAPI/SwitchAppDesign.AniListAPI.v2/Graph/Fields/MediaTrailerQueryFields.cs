using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media trailer query fields.
    /// </summary>
	public class MediaTrailerQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public MediaTrailerQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The trailer video id
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// The site the video is hosted by (Currently either youtube or dailymotion
		/// </summary>
		public GraphQueryField SiteQueryField()
		{
			return new GraphQueryField("site", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
