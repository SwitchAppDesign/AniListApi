using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ThreadCategoryQueryFields
	{
		public ThreadCategoryQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the category or media is of the media category.
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the category.
		/// </summary>
		public GraphQueryField NameQueryField()
		{
			return Name;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
			Name = new GraphQueryField("name", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
		}

	}
}
