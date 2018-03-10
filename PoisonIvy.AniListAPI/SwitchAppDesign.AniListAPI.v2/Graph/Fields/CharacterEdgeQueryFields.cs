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
    /// All available character edge query fields.
    /// </summary>
	public class CharacterEdgeQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    internal CharacterEdgeQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Staff, AniListQueryType.User };
	    }

        /// <summary>
        /// <param name="fields">The list of character query fields (found in <see cref="CharacterQueryFields"/>) to be used in the graph query (at least of character query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
	    {
	        var field = new GraphQueryField("node", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(CharacterQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

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
		/// The characters role in the media
		/// </summary>
		public GraphQueryField RoleQueryField()
		{
		    return new GraphQueryField("role", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The voice actors of the character.
        /// </summary>
        public GraphQueryField VoiceActorsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
        {
            var field = new GraphQueryField("voiceActors", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StaffQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
        }

        /// <summary>
        /// The media the character is in.
        /// </summary>
        public GraphQueryField MediaQueryField(IList<GraphQueryField> fields)
        {
            var field = new GraphQueryField("media", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaQueryFields)).GetGraphFieldAndSetFieldArguments(fields);
            
            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		/// <summary>
		/// The order the character should be displayed from the users favourites.
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
