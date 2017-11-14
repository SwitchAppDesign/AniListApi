using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    /// <summary>
    /// All available activity query arguments.
    /// </summary>
    public class ActivityQueryArgument
    {
        internal ActivityQueryArgument(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// Filter by the activity id.
        /// </summary>
        public GraphQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id.
        /// </summary>
        public GraphQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message.
        /// </summary>
        public GraphQueryArgument<int> MessengerIdQueryArgument(int value)
        {
            return MessengerId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the type of activity.
        /// </summary>
        public GraphQueryArgument<ActivityType> TypeQueryArgument(ActivityType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter activity to users who are being followed by the authenticated user.
        /// </summary>
        public GraphQueryArgument<bool> IsFollowingQueryArgument(bool value)
        {
            return IsFollowing.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter activity to only activity with replies.
        /// </summary>
        public GraphQueryArgument<bool> HasRepliesQueryArgument(bool value)
        {
            return HasReplies.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter activity to only activity with replies or is type text.
        /// </summary>
        public GraphQueryArgument<bool> HasRepliesOrTypeTextQueryArgument(bool value)
        {
            return HasRepliesOrTypeText.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the creation time of activity.
        /// </summary>
        public GraphQueryArgument<int> CreatedAtQueryArgument(int value)
        {
            return CreatedAt.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the activity id where the activity id is not equalt to the given value.
        /// </summary>
        public GraphQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the activity id where the activity id is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the activity id where the activity id is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id where the owner user id is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> UserIdNotQueryArgument(int value)
        {
            return UserIdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id where the owner user id is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> UserIdInQueryArgument(IEnumerable<int> value)
        {
            return UserIdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id where the owner user id is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> UserIdNotInQueryArgument(IEnumerable<int> value)
        {
            return UserIdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message where the user id is not equal to the given value.
        /// </summary>
        public GraphQueryArgument<int> MessengerIdNotQueryArgument(int value)
        {
            return MessengerIdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message where the user id is in the given collecton.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> MessengerIdInQueryArgument(IEnumerable<int> value)
        {
            return MessengerIdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message where the user id is not in the given collecton.
        /// </summary>
        public GraphQueryArgument<IEnumerable<int>> MessengerIdNotInQueryArgument(IEnumerable<int> value)
        {
            return MessengerIdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the type of activity where is the type of activity is not equalt to the given value.
        /// </summary>
        public GraphQueryArgument<ActivityType> TypeNotQueryArgument(ActivityType value)
        {
            return TypeNot.GetQueryArgumentAndSetValue(value);

        }

        /// <summary>
        /// Filter by the type of activity where the type of activity is in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<ActivityType>> TypeInQueryArgument(IEnumerable<ActivityType> value)
        {
            return TypeIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the type of activity where the type of activity is not in the given collection.
        /// </summary>
        public GraphQueryArgument<IEnumerable<ActivityType>> TypeNotInQueryArgument(IEnumerable<ActivityType> value)
        {
            return TypeNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the creation time of activity where creation time of activity is greater than the given value.
        /// </summary>
        public GraphQueryArgument<int> CreatedAtGreaterThanQueryArgument(int value)
        {
            return CreatedAtGreater.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the creation time of activity where creation time of activity is lesser than the given value.
        /// </summary>
        public GraphQueryArgument<int> CreatedAtLesserThanQueryArgument(int value)
        {
            return CreatedAtLesser.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        public GraphQueryArgument<IEnumerable<ActivitySort>> SortQueryArgument(IEnumerable<ActivitySort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQueryArgument<int> Id { get; set; }
        private GraphQueryArgument<int> UserId { get; set; }
        private GraphQueryArgument<int> MessengerId { get; set; }
        private GraphQueryArgument<ActivityType> Type { get; set; }
        private GraphQueryArgument<bool> IsFollowing { get; set; }
        private GraphQueryArgument<bool> HasReplies { get; set; }
        private GraphQueryArgument<bool> HasRepliesOrTypeText { get; set; }
        private GraphQueryArgument<int> CreatedAt { get; set; }
        private GraphQueryArgument<int> IdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQueryArgument<int> UserIdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> UserIdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> UserIdNotIn { get; set; }
        private GraphQueryArgument<int> MessengerIdNot { get; set; }
        private GraphQueryArgument<IEnumerable<int>> MessengerIdIn { get; set; }
        private GraphQueryArgument<IEnumerable<int>> MessengerIdNotIn { get; set; }
        private GraphQueryArgument<ActivityType> TypeNot { get; set; }
        private GraphQueryArgument<IEnumerable<ActivityType>> TypeIn { get; set; }
        private GraphQueryArgument<IEnumerable<ActivityType>> TypeNotIn { get; set; }
        private GraphQueryArgument<int> CreatedAtGreater { get; set; }
        private GraphQueryArgument<int> CreatedAtLesser { get; set; }
        private GraphQueryArgument<IEnumerable<ActivitySort>> Sort { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryArgument<int>("id", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            UserId = new GraphQueryArgument<int>("userId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            MessengerId = new GraphQueryArgument<int>("messangerId", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            Type = new GraphQueryArgument<ActivityType>("type", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            IsFollowing = new GraphQueryArgument<bool>("isFollowing", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            HasReplies = new GraphQueryArgument<bool>("hasReplies", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            HasRepliesOrTypeText = new GraphQueryArgument<bool>("hasRepliesOrTypeText", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            CreatedAt = new GraphQueryArgument<int>("createdAt", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            IdNot = new GraphQueryArgument<int>("id_not", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            IdIn = new GraphQueryArgument<IEnumerable<int>>("id_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            IdNotIn = new GraphQueryArgument<IEnumerable<int>>("id_not_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            UserIdNot = new GraphQueryArgument<int>("userId_not", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            UserIdIn = new GraphQueryArgument<IEnumerable<int>>("userId_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            UserIdNotIn = new GraphQueryArgument<IEnumerable<int>>("userId_not_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            MessengerIdNot = new GraphQueryArgument<int>("messengerId_not", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            MessengerIdIn = new GraphQueryArgument<IEnumerable<int>>("messengerId_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            MessengerIdNotIn = new GraphQueryArgument<IEnumerable<int>>("messengerId_not_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            TypeNot = new GraphQueryArgument<ActivityType>("type_not", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            TypeIn = new GraphQueryArgument<IEnumerable<ActivityType>>("type_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            TypeNotIn = new GraphQueryArgument<IEnumerable<ActivityType>>("type_not_in", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            CreatedAtGreater = new GraphQueryArgument<int>("createdAt_greater", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            CreatedAtLesser = new GraphQueryArgument<int>("createdAt_lesser", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
            Sort = new GraphQueryArgument<IEnumerable<ActivitySort>>("sort", queryType, new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.Activity }));
        }
    }
}