using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class Favourites
	{
		public Favourites()
		{
			InitializeProperties();
		}

		public GraphQLQueryField AnimeQueryField { get; private set; }

		public GraphQLQueryField MangaQueryField { get; private set; }

		public GraphQLQueryField CharactersQueryField { get; private set; }

		public GraphQLQueryField StaffQueryField { get; private set; }

		public GraphQLQueryField StudiosQueryField { get; private set; }

		private void InitializeProperties()
		{
			AnimeQueryField = new GraphQLQueryField("anime", new FieldRules(false));
			MangaQueryField = new GraphQLQueryField("manga", new FieldRules(false));
			CharactersQueryField = new GraphQLQueryField("characters", new FieldRules(false));
			StaffQueryField = new GraphQLQueryField("staff", new FieldRules(false));
			StudiosQueryField = new GraphQLQueryField("studios", new FieldRules(false));
		}
	}
}
