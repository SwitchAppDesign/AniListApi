using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available image data query fields.
    /// </summary>
	public class ImageDataQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        internal ImageDataQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> {AniListQueryType.Media, AniListQueryType.Page};
        }

		/// <summary>
		/// The image at its largest size
		/// </summary>
		public GraphQueryField LargeQueryField()
		{
		    return new GraphQueryField("large", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// The image of media at medium size
		/// </summary>
		public GraphQueryField MediumQueryField()
		{
			return new GraphQueryField("medium", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
