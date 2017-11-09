using System;
using System.Collections.Generic;
using System.Text;
using SwitchAppDesign.AniListAPI.v2.Models;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Arguments
{
    internal class MediaListCollection
    {
        public MediaListCollection()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by a user's id.
        /// </summary>
        public GraphQLQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by a user's name.
        /// </summary>
        public GraphQLQueryArgument<string> UserNameQueryArgument(string value)
        {
            return UserName.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the list entries media type.
        /// </summary>
        public GraphQLQueryArgument<MediaType> TypeQueryArgument(MediaType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by note words and #tags.
        /// </summary>
        public GraphQLQueryArgument<string> NotesQueryArgument(string value)
        {
            return Notes.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> StartedAtQueryArgument(FuzzyDateInt value)
        {
            return StartedAt.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> CompletedAtQueryArgument(FuzzyDateInt value)
        {
            return CompletedAt.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by note words and #tags where note words and #tags are like the given value.
        /// </summary>
        public GraphQLQueryArgument<string> NotesLikeQueryArgument(string value)
        {
            return NotesLike.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media where the date the user start the media at is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> StartedAtGreaterThanQueryArgument(FuzzyDateInt value)
        {
            return StartedAtGreater.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media where the date the user start the media at is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> StartedAtLesserThanQueryArgument(FuzzyDateInt value)
        {
            return StartedAtLesser.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user started the media where the date the user started the media is like the given value.
        /// </summary>
        public GraphQLQueryArgument<string> StartedAtLikeQueryArgument(string value)
        {
            return StartedAtLike.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media where the date the user completed the media is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> CompletedAtGreaterThanQueryArgument(FuzzyDateInt value)
        {
            return CompletedAtGreater.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media where the date the user completed the media is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<FuzzyDateInt> CompletedAtLesserThanQueryArgument(FuzzyDateInt value)
        {
            return CompletedAtLesser.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the date the user completed the media where the date the user completed the media is like the given value.
        /// </summary>
        public GraphQLQueryArgument<string> CompletedAtLikeQueryArgument(string value)
        {
            return CompletedAtLike.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<MediaListSort>> SortQueryArgument(IEnumerable<MediaListSort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> UserId { get; set; }
        private GraphQLQueryArgument<string> UserName { get; set; }
        private GraphQLQueryArgument<MediaType> Type { get; set; }
        private GraphQLQueryArgument<string> Notes { get; set; }
        private GraphQLQueryArgument<FuzzyDateInt> StartedAt { get; set; }
        private GraphQLQueryArgument<FuzzyDateInt> CompletedAt { get; set; }
        private GraphQLQueryArgument<string> NotesLike { get; set; }
        private GraphQLQueryArgument<FuzzyDateInt> StartedAtGreater { get; set; }
        private GraphQLQueryArgument<FuzzyDateInt> StartedAtLesser { get; set; }
        private GraphQLQueryArgument<string> StartedAtLike { get; set; }
        private GraphQLQueryArgument<FuzzyDateInt> CompletedAtGreater { get; set; }
        private GraphQLQueryArgument<FuzzyDateInt> CompletedAtLesser { get; set; }
        private GraphQLQueryArgument<string> CompletedAtLike { get; set; }
        private GraphQLQueryArgument<IEnumerable<MediaListSort>> Sort { get; set; }

        private void InitializeProperties()
        {
            UserId = new GraphQLQueryArgument<int>("userId");
            UserName = new GraphQLQueryArgument<string>("userName");
            Type = new GraphQLQueryArgument<MediaType>("type");
            Notes = new GraphQLQueryArgument<string>("notes");
            StartedAt = new GraphQLQueryArgument<FuzzyDateInt>("startedAt");
            CompletedAt = new GraphQLQueryArgument<FuzzyDateInt>("completedAt");
            NotesLike = new GraphQLQueryArgument<string>("notes_like");
            StartedAtGreater = new GraphQLQueryArgument<FuzzyDateInt>("startedAt_greater");
            StartedAtLesser = new GraphQLQueryArgument<FuzzyDateInt>("startedAt_lesser");
            StartedAtLike = new GraphQLQueryArgument<string>("startedAt_like");
            CompletedAtGreater = new GraphQLQueryArgument<FuzzyDateInt>("completedAt_greater");
            CompletedAtLesser = new GraphQLQueryArgument<FuzzyDateInt>("completedAt_lesser");
            CompletedAtLike = new GraphQLQueryArgument<string>("completedAt_like");
            Sort = new GraphQLQueryArgument<IEnumerable<MediaListSort>>("sort");
        }
    }
}
