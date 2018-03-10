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
    /// All available staff query fields.
    /// </summary>
	public class StaffQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public StaffQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Staff, AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The id of the staff member
        /// </summary>
        public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The names of the staff member
        /// </summary>
        public GraphQueryField NameQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("name", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(NameQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

		    FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		/// <summary>
		/// The primary language of the staff member
		/// </summary>
		public GraphQueryField LanguageQueryField()
		{
		    return new GraphQueryField("language", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The staff images
        /// </summary>
        public GraphQueryField ImageQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("image", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ImageDataQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		/// <summary>
		/// A general description of the staff member
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
		    return new GraphQueryField("description", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the staff member is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
		    return new GraphQueryField("isFavourite", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The url for the staff page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
		    return new GraphQueryField("siteUrl", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// Media where the staff member has a production role
        /// </summary>
        public GraphQueryField StaffMediaQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("staffMedia", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
        }

        /// <summary>
        /// Characters voiced by the actor
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("characters", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(CharacterConnectionQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);
                
            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

		    return field;
		}
	}
}
