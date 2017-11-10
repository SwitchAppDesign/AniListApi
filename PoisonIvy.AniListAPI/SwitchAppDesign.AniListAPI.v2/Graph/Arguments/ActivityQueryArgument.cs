using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class ActivityQueryArgument
    {
        public ActivityQueryArgument()
        {
            InitializeProperties();
        }

        /// <summary>
        /// Filter by the activity id.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id.
        /// </summary>
        public GraphQLQueryArgument<int> UserIdQueryArgument(int value)
        {
            return UserId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message.
        /// </summary>
        public GraphQLQueryArgument<int> MessengerIdQueryArgument(int value)
        {
            return MessengerId.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the type of activity.
        /// </summary>
        public GraphQLQueryArgument<ActivityType> TypeQueryArgument(ActivityType value)
        {
            return Type.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter activity to users who are being followed by the authenticated user.
        /// </summary>
        public GraphQLQueryArgument<bool> IsFollowingQueryArgument(bool value)
        {
            return IsFollowing.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter activity to only activity with replies.
        /// </summary>
        public GraphQLQueryArgument<bool> HasRepliesQueryArgument(bool value)
        {
            return HasReplies.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter activity to only activity with replies or is type text.
        /// </summary>
        public GraphQLQueryArgument<bool> HasRepliesOrTypeTextQueryArgument(bool value)
        {
            return HasRepliesOrTypeText.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the creation time of activity.
        /// </summary>
        public GraphQLQueryArgument<int> CreatedAtQueryArgument(int value)
        {
            return CreatedAt.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the activity id where the activity id is not equalt to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> IdNotQueryArgument(int value)
        {
            return IdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the activity id where the activity id is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdInQueryArgument(IEnumerable<int> value)
        {
            return IdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the activity id where the activity id is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> IdNotInQueryArgument(IEnumerable<int> value)
        {
            return IdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id where the owner user id is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> UserIdNotQueryArgument(int value)
        {
            return UserIdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id where the owner user id is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> UserIdInQueryArgument(IEnumerable<int> value)
        {
            return UserIdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the owner user id where the owner user id is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> UserIdNotInQueryArgument(IEnumerable<int> value)
        {
            return UserIdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message where the user id is not equal to the given value.
        /// </summary>
        public GraphQLQueryArgument<int> MessengerIdNotQueryArgument(int value)
        {
            return MessengerIdNot.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message where the user id is in the given collecton.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> MessengerIdInQueryArgument(IEnumerable<int> value)
        {
            return MessengerIdIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the user id of the user who send the message where the user id is not in the given collecton.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<int>> MessengerIdNotInQueryArgument(IEnumerable<int> value)
        {
            return MessengerIdNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the type of activity where is the type of activity is not equalt to the given value.
        /// </summary>
        public GraphQLQueryArgument<ActivityType> TypeNotQueryArgument(ActivityType value)
        {
            return TypeNot.GetQueryArgumentAndSetValue(value);

        }

        /// <summary>
        /// Filter by the type of activity where the type of activity is in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<ActivityType>> TypeInQueryArgument(IEnumerable<ActivityType> value)
        {
            return TypeIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the type of activity where the type of activity is not in the given collection.
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<ActivityType>> TypeNotInQueryArgument(IEnumerable<ActivityType> value)
        {
            return TypeNotIn.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the creation time of activity where creation time of activity is greater than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> CreatedAtGreaterThanQueryArgument(int value)
        {
            return CreatedAtGreater.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// Filter by the creation time of activity where creation time of activity is lesser than the given value.
        /// </summary>
        public GraphQLQueryArgument<int> CreatedAtLesserThanQueryArgument(int value)
        {
            return CreatedAtLesser.GetQueryArgumentAndSetValue(value);
        }

        /// <summary>
        /// The order the results will be returned in
        /// </summary>
        public GraphQLQueryArgument<IEnumerable<ActivitySort>> SortQueryArgument(IEnumerable<ActivitySort> value)
        {
            return Sort.GetQueryArgumentAndSetValue(value);
        }

        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<int> UserId { get; set; }
        private GraphQLQueryArgument<int> MessengerId { get; set; }
        private GraphQLQueryArgument<ActivityType> Type { get; set; }
        private GraphQLQueryArgument<bool> IsFollowing { get; set; }
        private GraphQLQueryArgument<bool> HasReplies { get; set; }
        private GraphQLQueryArgument<bool> HasRepliesOrTypeText { get; set; }
        private GraphQLQueryArgument<int> CreatedAt { get; set; }
        private GraphQLQueryArgument<int> IdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> IdNotIn { get; set; }
        private GraphQLQueryArgument<int> UserIdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> UserIdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> UserIdNotIn { get; set; }
        private GraphQLQueryArgument<int> MessengerIdNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> MessengerIdIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<int>> MessengerIdNotIn { get; set; }
        private GraphQLQueryArgument<ActivityType> TypeNot { get; set; }
        private GraphQLQueryArgument<IEnumerable<ActivityType>> TypeIn { get; set; }
        private GraphQLQueryArgument<IEnumerable<ActivityType>> TypeNotIn { get; set; }
        private GraphQLQueryArgument<int> CreatedAtGreater { get; set; }
        private GraphQLQueryArgument<int> CreatedAtLesser { get; set; }
        private GraphQLQueryArgument<IEnumerable<ActivitySort>> Sort { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id");
            UserId = new GraphQLQueryArgument<int>("userId");
            MessengerId = new GraphQLQueryArgument<int>("messangerId");
            Type = new GraphQLQueryArgument<ActivityType>("type");
            IsFollowing = new GraphQLQueryArgument<bool>("isFollowing");
            HasReplies = new GraphQLQueryArgument<bool>("hasReplies");
            HasRepliesOrTypeText = new GraphQLQueryArgument<bool>("hasRepliesOrTypeText");
            CreatedAt = new GraphQLQueryArgument<int>("createdAt");
            IdNot = new GraphQLQueryArgument<int>("id_not");
            IdIn = new GraphQLQueryArgument<IEnumerable<int>>("id_in");
            IdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("id_not_in");
            UserIdNot = new GraphQLQueryArgument<int>("userId_not");
            UserIdIn = new GraphQLQueryArgument<IEnumerable<int>>("userId_in");
            UserIdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("userId_not_in");
            MessengerIdNot = new GraphQLQueryArgument<int>("messengerId_not");
            MessengerIdIn = new GraphQLQueryArgument<IEnumerable<int>>("messengerId_in");
            MessengerIdNotIn = new GraphQLQueryArgument<IEnumerable<int>>("messengerId_not_in");
            TypeNot = new GraphQLQueryArgument<ActivityType>("type_not");
            TypeIn = new GraphQLQueryArgument<IEnumerable<ActivityType>>("type_in");
            TypeNotIn = new GraphQLQueryArgument<IEnumerable<ActivityType>>("type_not_in");
            CreatedAtGreater = new GraphQLQueryArgument<int>("createdAt_greater");
            CreatedAtLesser = new GraphQLQueryArgument<int>("createdAt_lesser");
            Sort = new GraphQLQueryArgument<IEnumerable<ActivitySort>>("sort");
        }
    }
}