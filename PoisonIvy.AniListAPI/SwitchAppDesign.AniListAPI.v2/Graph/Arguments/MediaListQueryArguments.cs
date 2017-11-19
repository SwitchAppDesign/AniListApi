using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available media list query arguments.
    /// </summary>
    public class MediaListQueryArguments
    {
        internal MediaListQueryArguments(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by a list entry's id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by a user's id.
        /// </summary>
        public GraphQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by a user's name.
        /// </summary>
        public GraphQueryArgument<string> UserNameQueryArgument(string value)
        {
            return UserName.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the list entries media type.
        /// </summary>
        public GraphQueryArgument<MediaType> TypeQueryArgument(MediaType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the watching/reading status.
        /// </summary>
        public GraphQueryArgument<MediaListStatus> StatusQueryArgument(MediaListStatus value)
        {
            return Status.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the media id of the list entry.
        /// </summary>
        public GraphQueryArgument<int> MediaIdQueryArgument(int value)
        {
            return MediaId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by note words and #tags.
        /// </summary>
        public GraphQueryArgument<string> NotesQueryArgument(string value)
        {
            return Notes.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> StartedAtQueryArgument(FuzzyDateInt value)
        {
            return StartedAt.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> CompletedAtQueryArgument(FuzzyDateInt value)
        {
            return CompletedAt.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by note words and #tags where note words and #tags are like the given value.
        /// </summary>
        public GraphQueryArgument<string> NotesLikeQueryArgument(string value)
        {
            return NotesLike.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media where the date the user start the media at is greater than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> StartedAtGreaterThanQueryArgument(FuzzyDateInt value)
        {
            return StartedAtGreater.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media where the date the user start the media at is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> StartedAtLesserThanQueryArgument(FuzzyDateInt value)
        {
            return StartedAtLesser.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media where the date the user started the media is like the given value.
        /// </summary>
        public GraphQueryArgument<string> StartedAtLikeQueryArgument(string value)
        {
            return StartedAtLike.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media where the date the user completed the media is greater than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> CompletedAtGreaterThanQueryArgument(FuzzyDateInt value)
        {
            return CompletedAtGreater.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media where the date the user completed the media is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<FuzzyDateInt> CompletedAtLesserThanQueryArgument(FuzzyDateInt value)
        {
            return CompletedAtLesser.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media where the date the user completed the media is like the given value.
        /// </summary>
        public GraphQueryArgument<string> CompletedAtLikeQueryArgument(string value)
        {
            return CompletedAtLike.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        public GraphQueryArgument<IEnumerable<MediaListSort>> SortQueryArgument(IEnumerable<MediaListSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> UserId { get; set; }
        private GraphQueryArgument<string> UserName { get; set; }
        private GraphQueryArgument<MediaType> Type { get; set; }
        private GraphQueryArgument<MediaListStatus> Status { get; set; }
        private GraphQueryArgument<int> MediaId { get; set; }
        private GraphQueryArgument<string> Notes { get; set; }
        private GraphQueryArgument<FuzzyDateInt> StartedAt { get; set; }
        private GraphQueryArgument<FuzzyDateInt> CompletedAt { get; set; }
        private GraphQueryArgument<string> NotesLike { get; set; }
        private GraphQueryArgument<FuzzyDateInt> StartedAtGreater { get; set; }
        private GraphQueryArgument<FuzzyDateInt> StartedAtLesser { get; set; }
        private GraphQueryArgument<string> StartedAtLike { get; set; }
        private GraphQueryArgument<FuzzyDateInt> CompletedAtGreater { get; set; }
        private GraphQueryArgument<FuzzyDateInt> CompletedAtLesser { get; set; }
        private GraphQueryArgument<string> CompletedAtLike { get; set; }
        private GraphQueryArgument<IEnumerable<MediaListSort>> Sort { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            UserId = new GraphQueryArgument<int>("userId", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            UserName = new GraphQueryArgument<string>("userName", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            Type = new GraphQueryArgument<MediaType>("type", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            Status = new GraphQueryArgument<MediaListStatus>("status", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            MediaId = new GraphQueryArgument<int>("mediaId", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            Notes = new GraphQueryArgument<string>("notes", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            StartedAt = new GraphQueryArgument<FuzzyDateInt>("startedAt", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            CompletedAt = new GraphQueryArgument<FuzzyDateInt>("completedAt", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            NotesLike = new GraphQueryArgument<string>("notes_like", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            StartedAtGreater = new GraphQueryArgument<FuzzyDateInt>("startedAt_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            StartedAtLesser = new GraphQueryArgument<FuzzyDateInt>("startedAt_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            StartedAtLike = new GraphQueryArgument<string>("startedAt_like", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            CompletedAtGreater = new GraphQueryArgument<FuzzyDateInt>("completedAt_greater", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            CompletedAtLesser = new GraphQueryArgument<FuzzyDateInt>("completedAt_lesser", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            CompletedAtLike = new GraphQueryArgument<string>("completedAt_like", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
            Sort = new GraphQueryArgument<IEnumerable<MediaListSort>>("sort", GetType(), queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaList }));
        }
    }
}
