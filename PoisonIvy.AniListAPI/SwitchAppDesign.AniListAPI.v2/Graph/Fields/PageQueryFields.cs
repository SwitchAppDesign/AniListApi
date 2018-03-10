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
    /// All available page query fields.
    /// </summary>
	public class PageQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

	    public PageQueryFields(AniListQueryType queryType)
	    {
	        _queryType = queryType;
	        _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Page };
	    }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }

        /// <summary>
        /// The pagination information
        /// </summary>
        public GraphQueryField PageInfoQueryField(IList<GraphQueryField> fields)
		{
		    var field = new GraphQueryField("pageInfo", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(PageInfoQueryFields)).GetGraphFieldAndSetFieldArguments(fields);

            FieldAndArgumentHelper.ValidateQueryFields(field, fields);

            return field;
        }

		public GraphQueryField UsersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("users", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(UserQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField MediaQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
	    {
	        var field = new GraphQueryField("media", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

	        FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field.GetGraphFieldAndSetFieldArguments(fields, arguments);
	    }

        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
        {
            var field = new GraphQueryField("characters", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(CharacterQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

            FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField StaffQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("staff", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StaffQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField StudiosQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("studios", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(StudioQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField MediaListQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("mediaList", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(MediaListQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField AiringSchedulesQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("airingSchedules", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(AiringScheduleQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField FollowersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("followers", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(AiringScheduleQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField FollowingsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("followings", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(AiringScheduleQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField ActivityRepliesQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("activityReplies", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ActivityReplyQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField ThreadsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("threads", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ThreadQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField ThreadCommentsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("threadComments", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ThreadCommentQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}

		public GraphQueryField ReviewsQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    var field = new GraphQueryField("reviews", GetType(), _queryType, InitilizeDefaultFieldRules(), typeof(ReviewQueryFields)).GetGraphFieldAndSetFieldArguments(fields, arguments);

		    FieldAndArgumentHelper.ValidateQueryFieldsAndArguments(field, fields, arguments);

            return field;
		}
	}
}
