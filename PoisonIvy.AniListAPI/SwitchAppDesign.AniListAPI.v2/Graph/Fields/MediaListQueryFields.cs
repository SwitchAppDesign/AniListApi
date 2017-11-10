using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class MediaList
    {
        public MediaList()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the user
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The id of the user owner of the list entry
        /// </summary>
        public GraphQLQueryField UserIdQueryField { get; private set; }

        /// <summary>
        /// The id of the media
        /// </summary>
        public GraphQLQueryField MediaIdQueryField { get; private set; }

        /// <summary>
        /// The watching/reading status
        /// </summary>
        public GraphQLQueryField StatusQueryField { get; private set; }

        /// <summary>
        /// The score of the entry
        /// </summary>
        public GraphQLQueryField ScoreQueryField { get; private set; }

        /// <summary>
        /// The amount of episodes/chapters consumed by the user
        /// </summary>
        public GraphQLQueryField ProgressQueryField { get; private set; }

        /// <summary>
        /// The amount of volumes read by the user
        /// </summary>
        public GraphQLQueryField ProgressVolumesQueryField { get; private set; }

        /// <summary>
        /// The amount of times the user has rewatched/read the media
        /// </summary>
        public GraphQLQueryField RepeatQueryField { get; private set; }

        /// <summary>
        /// Priority of planning
        /// </summary>
        public GraphQLQueryField PriorityQueryField { get; private set; }

        /// <summary>
        /// If the entry should only be visible to authenticated user
        /// </summary>
        public GraphQLQueryField _privateQueryField { get; private set; }

        /// <summary>
        /// Text notes
        /// </summary>
        public GraphQLQueryField NotesQueryField { get; private set; }

        /// <summary>
        /// If the entry shown be hidden from non-custom lists
        /// </summary>
        public GraphQLQueryField HiddenFromStatusListsQueryField { get; private set; }

        /// <summary>
        /// Map of booleans for which custom lists the entry are in
        /// </summary>
        public GraphQLQueryField CustomListsQueryField { get; private set; }

        /// <summary>
        /// Map of advanced scores with name keys
        /// </summary>
        public GraphQLQueryField AdvancedScoresQueryField { get; private set; }

        /// <summary>
        /// When the entry was started by the user
        /// </summary>
        public GraphQLQueryField StartedAtQueryField { get; private set; }

        /// <summary>
        /// When the entry was completed by the user
        /// </summary>
        public GraphQLQueryField CompletedAtQueryField { get; private set; }

        /// <summary>
        /// When the entry data was last updated
        /// </summary>
        public GraphQLQueryField UpdatedAtQueryField { get; private set; }

        /// <summary>
        /// When the entry data was created
        /// </summary>
        public GraphQLQueryField CreatedAtQueryField { get; private set; }

        /// <summary>
        /// The id of the media
        /// </summary>
        public GraphQLQueryField MediaQueryField { get; private set; }

        /// <summary>
        /// The id of the user owner of the list entry
        /// </summary>
        public GraphQLQueryField UserQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            UserIdQueryField = new GraphQLQueryField("userId", new FieldRules(false));
            MediaIdQueryField = new GraphQLQueryField("mediaId", new FieldRules(false));
            StatusQueryField = new GraphQLQueryField("status", new FieldRules(false));
            ScoreQueryField = new GraphQLQueryField("score", new FieldRules(false));
            ProgressQueryField = new GraphQLQueryField("progress", new FieldRules(false));
            ProgressVolumesQueryField = new GraphQLQueryField("progressVolumes", new FieldRules(false));
            RepeatQueryField = new GraphQLQueryField("repeat", new FieldRules(false));
            PriorityQueryField = new GraphQLQueryField("priority", new FieldRules(false));
            _privateQueryField = new GraphQLQueryField("_private", new FieldRules(false));
            NotesQueryField = new GraphQLQueryField("notes", new FieldRules(false));
            HiddenFromStatusListsQueryField = new GraphQLQueryField("hiddenFromStatusLists", new FieldRules(false));
            CustomListsQueryField = new GraphQLQueryField("customLists", new FieldRules(false));
            AdvancedScoresQueryField = new GraphQLQueryField("advancedScores", new FieldRules(false));
            StartedAtQueryField = new GraphQLQueryField("startedAt", new FieldRules(false));
            CompletedAtQueryField = new GraphQLQueryField("completedAt", new FieldRules(false));
            UpdatedAtQueryField = new GraphQLQueryField("updatedAt", new FieldRules(false));
            CreatedAtQueryField = new GraphQLQueryField("createdAt", new FieldRules(false));
            MediaQueryField = new GraphQLQueryField("media", new FieldRules(false));
            UserQueryField = new GraphQLQueryField("user", new FieldRules(false));
        }
    }
}
