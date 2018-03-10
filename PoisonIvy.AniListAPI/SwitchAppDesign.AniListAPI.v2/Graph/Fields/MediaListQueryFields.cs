using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media list query fields.
    /// </summary>
	public class MediaListQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        internal MediaListQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> {AniListQueryType.MediaList};
        }

		/// <summary>
		/// The id of the user
		/// </summary>
		public GraphQueryField IdQueryField()
		{
		    return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the user owner of the list entry
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
		    return new GraphQueryField("userId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQueryField MediaIdQueryField()
		{
		    return new GraphQueryField("mediaId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The watching/reading status
		/// </summary>
		public GraphQueryField StatusQueryField()
		{
		    return new GraphQueryField("status", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The score of the entry
		/// </summary>
		public GraphQueryField ScoreQueryField()
		{
		    return new GraphQueryField("score", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The amount of episodes/chapters consumed by the user
		/// </summary>
		public GraphQueryField ProgressQueryField()
		{
		    return new GraphQueryField("progress", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The amount of volumes read by the user
		/// </summary>
		public GraphQueryField ProgressVolumesQueryField()
		{
		    return new GraphQueryField("progressVolumes", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The amount of times the user has rewatched/read the media
		/// </summary>
		public GraphQueryField RepeatQueryField()
		{
		    return new GraphQueryField("repeat", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Priority of planning
		/// </summary>
		public GraphQueryField PriorityQueryField()
		{
		    return new GraphQueryField("priority", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the entry should only be visible to authenticated user
		/// </summary>
		public GraphQueryField _privateQueryField()
		{
		    return new GraphQueryField("_private", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Text notes
		/// </summary>
		public GraphQueryField NotesQueryField()
		{
		    return new GraphQueryField("notes", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// If the entry shown be hidden from non-custom lists
		/// </summary>
		public GraphQueryField HiddenFromStatusListsQueryField()
		{
		    return new GraphQueryField("hiddenFromStatusLists", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Map of booleans for which custom lists the entry are in
		/// </summary>
		public GraphQueryField CustomListsQueryField()
		{
		    return new GraphQueryField("customLists", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// Map of advanced scores with name keys
		/// </summary>
		public GraphQueryField AdvancedScoresQueryField()
		{
		    return new GraphQueryField("advancedScores", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// When the entry was started by the user
		/// </summary>
		public GraphQueryField StartedAtQueryField()
		{
		    return new GraphQueryField("startedAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// When the entry was completed by the user
		/// </summary>
		public GraphQueryField CompletedAtQueryField()
		{
		    return new GraphQueryField("completedAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// When the entry data was last updated
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
		    return new GraphQueryField("updatedAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// When the entry data was created
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
		    return new GraphQueryField("createdAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQueryField MediaQueryField()
		{
		    return new GraphQueryField("media", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		/// <summary>
		/// The id of the user owner of the list entry
		/// </summary>
		public GraphQueryField UserQueryField()
		{
			return new GraphQueryField("user", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
