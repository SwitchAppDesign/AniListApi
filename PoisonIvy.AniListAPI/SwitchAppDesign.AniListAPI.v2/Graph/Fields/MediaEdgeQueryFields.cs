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
		internal MediaEdgeQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

        /// <summary>
        /// <param name="fields">The list of media query fields (found in <see cref="MediaQueryFields"/>) to be used in the graph query (at least of media query field is required).</param>
        /// </summary>
        public GraphQueryField NodeQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Node.GetType().Name}) requires at least one media query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media query fields {fields.Where(x => x.ParentClassType != typeof(MediaQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Node.GetGraphFieldAndSetFieldArguments(fields);
        }

		/// <summary>
		/// The id of the connection
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The type of relation to the parent model
		/// </summary>
		public GraphQueryField RelationTypeQueryField()
		{
			return RelationType;
		}

		/// <summary>
		/// If the studio is the main animation studio of the media (For Studio->MediaConnection field only)
		/// </summary>
		public GraphQueryField IsMainStudioQueryField()
		{
			return IsMainStudio;
		}

        /// <summary>
        /// The characters in the media voiced by the parent actor
        /// <param name="fields">The list of character query fields (found in <see cref="CharactersQueryField"/>) to be used in the graph query (at least of character query field is required).</param>
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Characters.GetType().Name}) requires at least one character query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(CharacterQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid character query fields {fields.Where(x => x.ParentClassType != typeof(CharacterQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Characters.GetGraphFieldAndSetFieldArguments(fields);
        }

		/// <summary>
		/// The characters role in the media
		/// </summary>
		public GraphQueryField CharacterRoleQueryField()
		{
			return CharacterRole;
		}

		/// <summary>
		/// The role of the staff member in the production of the media
		/// </summary>
		public GraphQueryField StaffRoleQueryField()
		{
			return StaffRole;
		}

        /// <summary>
        /// The voice actors of the character
        /// <param name="fields">The list of staff fields (found in <see cref="StaffQueryFields"/>) to be used in the graph query (at least of staff query field is required).</param>
        /// <param name="arguments">The list of staff arguments (found in <see cref="StaffQueryArguments"/>) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>language:</term><description>The staff language.</description></item>
        /// <item><term>sort:</term><description>The fields to sort by.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField VoiceActorsQueryField(IList<GraphQueryField> fields, IList<GraphQueryArgument<object>> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({VoiceActors.GetType().Name}) requires at least one staff query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(StaffQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid staff query fields {fields.Where(x => x.ParentClassType != typeof(StaffQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(StaffQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid staff query arguments {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(StaffQueryArguments))
		                    .Select(x => x.GetType().Name)
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

		    return VoiceActors.GetGraphFieldAndSetFieldArguments(fields, arguments);
        }

		/// <summary>
		/// The order the media should be displayed from the users favourites
		/// </summary>
		public GraphQueryField FavouriteOrderQueryField()
		{
			return FavouriteOrder;
		}

		private GraphQueryField Node { get; set; }
		private GraphQueryField Id { get; set; }
		private GraphQueryField RelationType { get; set; }
		private GraphQueryField IsMainStudio { get; set; }
		private GraphQueryField Characters { get; set; }
		private GraphQueryField CharacterRole { get; set; }
		private GraphQueryField StaffRole { get; set; }
		private GraphQueryField VoiceActors { get; set; }
		private GraphQueryField FavouriteOrder { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Node = new GraphQueryField("node", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			RelationType = new GraphQueryField("relationType", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsMainStudio = new GraphQueryField("isMainStudio", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Characters = new GraphQueryField("characters", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			CharacterRole = new GraphQueryField("characterRole", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			StaffRole = new GraphQueryField("staffRole", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			VoiceActors = new GraphQueryField("voiceActors", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			FavouriteOrder = new GraphQueryField("favouriteOrder", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
