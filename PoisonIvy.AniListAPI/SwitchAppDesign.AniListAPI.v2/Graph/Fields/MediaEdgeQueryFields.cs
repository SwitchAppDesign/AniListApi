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
    /// All available media edge query fields.
    /// </summary>
	public class MediaEdgeQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        internal MediaEdgeQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> {AniListQueryType.Media, AniListQueryType.Page};
        }

        /// <summary>
        /// <param name="fields">The list of media query fields (found in <see cref="MediaQueryFields"/>) to be used in the graph query (at least of media query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("node", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
        }

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The type of relation to the parent model
		/// </summary>
		public GraphQueryField RelationTypeQueryField()
		{
		    return new GraphQueryField("relationType", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the studio is the main animation studio of the media (For Studio->MediaConnection field only)
		/// </summary>
		public GraphQueryField IsMainStudioQueryField()
		{
		    return new GraphQueryField("isMainStudio", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The characters in the media voiced by the parent actor
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("characters", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

		    return field;
        }

		/// <summary>
		/// The characters role in the media
		/// </summary>
		public GraphQueryField CharacterRoleQueryField()
		{
		    return new GraphQueryField("characterRole", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The role of the staff member in the production of the media
		/// </summary>
		public GraphQueryField StaffRoleQueryField()
		{
		    return new GraphQueryField("staffRole", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The voice actors of the character
        /// </summary>
        public GraphQueryField VoiceActorsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("voiceActors", GetType(), _queryType, InitilizeDefaultFieldRules()).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

		    return field;
        }

		/// <summary>
		/// The order the media should be displayed from the users favourites
		/// </summary>
		public GraphQueryField FavouriteOrderQueryField()
		{
		    return new GraphQueryField("favouriteOrder", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

        private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
