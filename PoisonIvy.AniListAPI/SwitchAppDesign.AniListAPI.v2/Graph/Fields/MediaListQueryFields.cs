using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaListQueryFields
	{
		public MediaListQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the user
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The id of the user owner of the list entry
		/// </summary>
		public GraphQLQueryField UserIdQueryField()
		{
			return UserId;
		}

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQLQueryField MediaIdQueryField()
		{
			return MediaId;
		}

		/// <summary>
		/// The watching/reading status
		/// </summary>
		public GraphQLQueryField StatusQueryField()
		{
			return Status;
		}

		/// <summary>
		/// The score of the entry
		/// </summary>
		public GraphQLQueryField ScoreQueryField()
		{
			return Score;
		}

		/// <summary>
		/// The amount of episodes/chapters consumed by the user
		/// </summary>
		public GraphQLQueryField ProgressQueryField()
		{
			return Progress;
		}

		/// <summary>
		/// The amount of volumes read by the user
		/// </summary>
		public GraphQLQueryField ProgressVolumesQueryField()
		{
			return ProgressVolumes;
		}

		/// <summary>
		/// The amount of times the user has rewatched/read the media
		/// </summary>
		public GraphQLQueryField RepeatQueryField()
		{
			return Repeat;
		}

		/// <summary>
		/// Priority of planning
		/// </summary>
		public GraphQLQueryField PriorityQueryField()
		{
			return Priority;
		}

		/// <summary>
		/// If the entry should only be visible to authenticated user
		/// </summary>
		public GraphQLQueryField _privateQueryField()
		{
			return _private;
		}

		/// <summary>
		/// Text notes
		/// </summary>
		public GraphQLQueryField NotesQueryField()
		{
			return Notes;
		}

		/// <summary>
		/// If the entry shown be hidden from non-custom lists
		/// </summary>
		public GraphQLQueryField HiddenFromStatusListsQueryField()
		{
			return HiddenFromStatusLists;
		}

		/// <summary>
		/// Map of booleans for which custom lists the entry are in
		/// </summary>
		public GraphQLQueryField CustomListsQueryField()
		{
			return CustomLists;
		}

		/// <summary>
		/// Map of advanced scores with name keys
		/// </summary>
		public GraphQLQueryField AdvancedScoresQueryField()
		{
			return AdvancedScores;
		}

		/// <summary>
		/// When the entry was started by the user
		/// </summary>
		public GraphQLQueryField StartedAtQueryField()
		{
			return StartedAt;
		}

		/// <summary>
		/// When the entry was completed by the user
		/// </summary>
		public GraphQLQueryField CompletedAtQueryField()
		{
			return CompletedAt;
		}

		/// <summary>
		/// When the entry data was last updated
		/// </summary>
		public GraphQLQueryField UpdatedAtQueryField()
		{
			return UpdatedAt;
		}

		/// <summary>
		/// When the entry data was created
		/// </summary>
		public GraphQLQueryField CreatedAtQueryField()
		{
			return CreatedAt;
		}

		/// <summary>
		/// The id of the media
		/// </summary>
		public GraphQLQueryField MediaQueryField()
		{
			return Media;
		}

		/// <summary>
		/// The id of the user owner of the list entry
		/// </summary>
		public GraphQLQueryField UserQueryField()
		{
			return User;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField UserId { get; set; }
		private GraphQLQueryField MediaId { get; set; }
		private GraphQLQueryField Status { get; set; }
		private GraphQLQueryField Score { get; set; }
		private GraphQLQueryField Progress { get; set; }
		private GraphQLQueryField ProgressVolumes { get; set; }
		private GraphQLQueryField Repeat { get; set; }
		private GraphQLQueryField Priority { get; set; }
		private GraphQLQueryField _private { get; set; }
		private GraphQLQueryField Notes { get; set; }
		private GraphQLQueryField HiddenFromStatusLists { get; set; }
		private GraphQLQueryField CustomLists { get; set; }
		private GraphQLQueryField AdvancedScores { get; set; }
		private GraphQLQueryField StartedAt { get; set; }
		private GraphQLQueryField CompletedAt { get; set; }
		private GraphQLQueryField UpdatedAt { get; set; }
		private GraphQLQueryField CreatedAt { get; set; }
		private GraphQLQueryField Media { get; set; }
		private GraphQLQueryField User { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			UserId = new GraphQLQueryField("userId", new FieldRules(false));
			MediaId = new GraphQLQueryField("mediaId", new FieldRules(false));
			Status = new GraphQLQueryField("status", new FieldRules(false));
			Score = new GraphQLQueryField("score", new FieldRules(false));
			Progress = new GraphQLQueryField("progress", new FieldRules(false));
			ProgressVolumes = new GraphQLQueryField("progressVolumes", new FieldRules(false));
			Repeat = new GraphQLQueryField("repeat", new FieldRules(false));
			Priority = new GraphQLQueryField("priority", new FieldRules(false));
			_private = new GraphQLQueryField("_private", new FieldRules(false));
			Notes = new GraphQLQueryField("notes", new FieldRules(false));
			HiddenFromStatusLists = new GraphQLQueryField("hiddenFromStatusLists", new FieldRules(false));
			CustomLists = new GraphQLQueryField("customLists", new FieldRules(false));
			AdvancedScores = new GraphQLQueryField("advancedScores", new FieldRules(false));
			StartedAt = new GraphQLQueryField("startedAt", new FieldRules(false));
			CompletedAt = new GraphQLQueryField("completedAt", new FieldRules(false));
			UpdatedAt = new GraphQLQueryField("updatedAt", new FieldRules(false));
			CreatedAt = new GraphQLQueryField("createdAt", new FieldRules(false));
			Media = new GraphQLQueryField("media", new FieldRules(false));
			User = new GraphQLQueryField("user", new FieldRules(false));
		}
	}
}
