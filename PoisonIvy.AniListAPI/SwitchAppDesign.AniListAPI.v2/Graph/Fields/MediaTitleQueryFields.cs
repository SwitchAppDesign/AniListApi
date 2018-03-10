using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media title query fields.
    /// </summary>
    public class MediaTitleQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public MediaTitleQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The romanization of the native language title
        /// </summary>
        public GraphQueryField RomajiQueryField()
		{
		    return new GraphQueryField("romaji", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The official english title
		/// </summary>
		public GraphQueryField EnglishQueryField()
		{
		    return new GraphQueryField("english", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Official title in it's native language
		/// </summary>
		public GraphQueryField NativeQueryField()
		{
		    return new GraphQueryField("native", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// The currently authenticated users preferred title language. Default romaji for non-authenticaed
		/// </summary>
		public GraphQueryField UserPreferredQueryField()
		{
			return new GraphQueryField("userPreferred", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
