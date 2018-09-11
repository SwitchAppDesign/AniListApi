using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available character query fields.
    /// </summary>
	public class MediaTagQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public MediaTagQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The id of the tag
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The name of the tag
		/// </summary>
		public GraphQueryField NameQueryField()
		{
		    return new GraphQueryField("name", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// A general description of the tag
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
		    return new GraphQueryField("description", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The categories of tags this tag belongs to
		/// </summary>
		public GraphQueryField CategoryQueryField()
		{
		    return new GraphQueryField("category", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The relevance ranking of the tag out of the 100 for this media
		/// </summary>
		public GraphQueryField RankQueryField()
		{
		    return new GraphQueryField("rank", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the tag could be a spoiler for any media
		/// </summary>
		public GraphQueryField IsGeneralSpoilerQueryField()
		{
		    return new GraphQueryField("isGeneralSpoiler", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the tag is a spoiler for this media
		/// </summary>
		public GraphQueryField IsMediaSpoilerQueryField()
		{
		    return new GraphQueryField("isMediaSpoiler", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// If the tag is only for adult 18+ media
		/// </summary>
		public GraphQueryField IsAdultQueryField()
		{
			return new GraphQueryField("isAdult", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
