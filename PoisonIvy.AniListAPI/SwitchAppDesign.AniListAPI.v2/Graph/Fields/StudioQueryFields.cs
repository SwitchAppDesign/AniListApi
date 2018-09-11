using System;
using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All Available studio query fields.
    /// </summary>
	public class StudioQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public StudioQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The id of the studio
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The name of the studio
		/// </summary>
		public GraphQueryField NameQueryField()
		{
		    return new GraphQueryField("name", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The media the studio has worked on
        /// </summary>
        public GraphQueryField MediaQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("media", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments, typeof(MediaConnectionQueryFields), typeof(MediaConnectionQueryArguments));

		    return field;
        }

		/// <summary>
		/// The url for the studio page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
		    return new GraphQueryField("siteUrl", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// If the studio is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return new GraphQueryField("isFavourite", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
	}
}
