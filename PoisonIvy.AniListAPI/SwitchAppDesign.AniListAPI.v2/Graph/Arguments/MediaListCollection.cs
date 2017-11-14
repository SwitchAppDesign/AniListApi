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
    /// All available media list collection query arguments.
    /// </summary>
    public class MediaListCollection
    {
        internal MediaListCollection(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
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

        private GraphQueryArgument<int> UserId { get; set; }
        private GraphQueryArgument<string> UserName { get; set; }
        private GraphQueryArgument<MediaType> Type { get; set; }
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
            UserId = new GraphQueryArgument<int>("userId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            UserName = new GraphQueryArgument<string>("userName", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            Type = new GraphQueryArgument<MediaType>("type", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            Notes = new GraphQueryArgument<string>("notes", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            StartedAt = new GraphQueryArgument<FuzzyDateInt>("startedAt", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            CompletedAt = new GraphQueryArgument<FuzzyDateInt>("completedAt", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            NotesLike = new GraphQueryArgument<string>("notes_like", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            StartedAtGreater = new GraphQueryArgument<FuzzyDateInt>("startedAt_greater", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            StartedAtLesser = new GraphQueryArgument<FuzzyDateInt>("startedAt_lesser", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            StartedAtLike = new GraphQueryArgument<string>("startedAt_like", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            CompletedAtGreater = new GraphQueryArgument<FuzzyDateInt>("completedAt_greater", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            CompletedAtLesser = new GraphQueryArgument<FuzzyDateInt>("completedAt_lesser", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            CompletedAtLike = new GraphQueryArgument<string>("completedAt_like", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
            Sort = new GraphQueryArgument<IEnumerable<MediaListSort>>("sort", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.MediaListCollection }));
        }
    }
}
