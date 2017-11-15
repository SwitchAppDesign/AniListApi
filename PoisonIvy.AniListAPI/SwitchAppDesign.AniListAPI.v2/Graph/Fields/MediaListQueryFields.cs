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
		internal MediaListQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the user
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The id of the user owner of the list entry
		/// </summary>
		public GraphQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQueryField MediaIdQueryField()
		{
			return MediaId;
		}

		/// <summary>
		/// The watching/reading status
		/// </summary>
		public GraphQueryField StatusQueryField()
		{
			return Status;
		}

		/// <summary>
		/// The score of the entry
		/// </summary>
		public GraphQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// The amount of episodes/chapters consumed by the user
		/// </summary>
		public GraphQueryField ProgressQueryField()
		{
			return Progress;
		}

		/// <summary>
		/// The amount of volumes read by the user
		/// </summary>
		public GraphQueryField ProgressVolumesQueryField()
		{
			return ProgressVolumes;
		}

		/// <summary>
		/// The amount of times the user has rewatched/read the media
		/// </summary>
		public GraphQueryField RepeatQueryField()
		{
			return Repeat;
		}

		/// <summary>
		/// Priority of planning
		/// </summary>
		public GraphQueryField PriorityQueryField()
		{
			return Priority;
		}

		/// <summary>
		/// If the entry should only be visible to authenticated user
		/// </summary>
		public GraphQueryField _privateQueryField()
		{
			return _private;
		}

		/// <summary>
		/// Text notes
		/// </summary>
		public GraphQueryField NotesQueryField()
		{
			return Notes;
		}

		/// <summary>
		/// If the entry shown be hidden from non-custom lists
		/// </summary>
		public GraphQueryField HiddenFromStatusListsQueryField()
		{
			return HiddenFromStatusLists;
		}

		/// <summary>
		/// Map of booleans for which custom lists the entry are in
		/// </summary>
		public GraphQueryField CustomListsQueryField()
		{
			return CustomLists;
		}

		/// <summary>
		/// Map of advanced scores with name keys
		/// </summary>
		public GraphQueryField AdvancedScoresQueryField()
		{
			return AdvancedScores;
		}

		/// <summary>
		/// When the entry was started by the user
		/// </summary>
		public GraphQueryField StartedAtQueryField()
		{
			return StartedAt;
		}

		/// <summary>
		/// When the entry was completed by the user
		/// </summary>
		public GraphQueryField CompletedAtQueryField()
		{
			return CompletedAt;
		}

		/// <summary>
		/// When the entry data was last updated
		/// </summary>
		public GraphQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// When the entry data was created
		/// </summary>
		public GraphQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQueryField MediaQueryField()
		{
			return Media;
		}

		/// <summary>
		/// The id of the user owner of the list entry
		/// </summary>
		public GraphQueryField UserQueryField()
		{
			return User;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField UserId { get; set; }
		private GraphQueryField MediaId { get; set; }
		private GraphQueryField Status { get; set; }
		private GraphQueryField Score { get; set; }
		private GraphQueryField Progress { get; set; }
		private GraphQueryField ProgressVolumes { get; set; }
		private GraphQueryField Repeat { get; set; }
		private GraphQueryField Priority { get; set; }
		private GraphQueryField _private { get; set; }
		private GraphQueryField Notes { get; set; }
		private GraphQueryField HiddenFromStatusLists { get; set; }
		private GraphQueryField CustomLists { get; set; }
		private GraphQueryField AdvancedScores { get; set; }
		private GraphQueryField StartedAt { get; set; }
		private GraphQueryField CompletedAt { get; set; }
		private GraphQueryField UpdatedAt { get; set; }
		private GraphQueryField CreatedAt { get; set; }
		private GraphQueryField Media { get; set; }
		private GraphQueryField User { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			UserId = new GraphQueryField("userId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			MediaId = new GraphQueryField("mediaId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Status = new GraphQueryField("status", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Score = new GraphQueryField("score", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Progress = new GraphQueryField("progress", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			ProgressVolumes = new GraphQueryField("progressVolumes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Repeat = new GraphQueryField("repeat", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Priority = new GraphQueryField("priority", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			_private = new GraphQueryField("_private", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Notes = new GraphQueryField("notes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			HiddenFromStatusLists = new GraphQueryField("hiddenFromStatusLists", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			CustomLists = new GraphQueryField("customLists", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			AdvancedScores = new GraphQueryField("advancedScores", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			StartedAt = new GraphQueryField("startedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			CompletedAt = new GraphQueryField("completedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			UpdatedAt = new GraphQueryField("updatedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			CreatedAt = new GraphQueryField("createdAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			Media = new GraphQueryField("media", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
			User = new GraphQueryField("user", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.MediaList }));
		}
	}
}
