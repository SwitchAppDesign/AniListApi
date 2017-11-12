using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class ThreadCategoryQueryFields
	{
		public ThreadCategoryQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the category or media is of the media category.
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the category.
		/// </summary>
		public GraphQLQueryField NameQueryField()
		{
			return Name;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Name { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Name = new GraphQLQueryField("name", new FieldRules(false));
		}
	}
}
