using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaListTypeOptionsQueryFields
	{
	    private readonly List<AniListQueryType> _allowedQueryTypes;
	    private readonly AniListQueryType _queryType;

        public MediaListTypeOptionsQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;

            _allowedQueryTypes = new List<AniListQueryType>
            {
                AniListQueryType.MediaList
            };
        }

		public GraphQueryField SectionOrderQueryField()
		{
		    return new GraphQueryField("sectionOrder", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		public GraphQueryField SplitCompletedSectionByFormatQueryField()
		{
		    return new GraphQueryField("splitCompletedSectionByFormat", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		public GraphQueryField CustomListsQueryField()
		{
		    return new GraphQueryField("customLists", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

		public GraphQueryField AdvancedScoringQueryField()
		{
		    return new GraphQueryField("advancedScoring", GetType(), _queryType, InitilizeDefaultFieldRules());
		    
        }

		public GraphQueryField AdvancedScoringEnabledQueryField()
		{
		    return new GraphQueryField("advancedScoringEnabled", GetType(), _queryType, InitilizeDefaultFieldRules());
        }

	    private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
	    {
	        return new FieldRules(authenticationRequired, _allowedQueryTypes);
	    }
    }
}
