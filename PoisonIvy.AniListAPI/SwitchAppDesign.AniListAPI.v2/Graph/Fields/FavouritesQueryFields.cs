using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FavouritesQueryFields
	{
		public FavouritesQueryFields()
		{
			InitializeProperties();
		}

		public GraphQLQueryField AnimeQueryField()
		{
			return Anime;
		}

		public GraphQLQueryField MangaQueryField()
		{
			return Manga;
		}

		public GraphQLQueryField CharactersQueryField()
		{
			return Characters;
		}

		public GraphQLQueryField StaffQueryField()
		{
			return Staff;
		}

		public GraphQLQueryField StudiosQueryField()
		{
			return Studios;
		}

		private GraphQLQueryField Anime { get; set; }
		private GraphQLQueryField Manga { get; set; }
		private GraphQLQueryField Characters { get; set; }
		private GraphQLQueryField Staff { get; set; }
		private GraphQLQueryField Studios { get; set; }

		private void InitializeProperties()
		{
			Anime = new GraphQLQueryField("anime", new FieldRules(false));
			Manga = new GraphQLQueryField("manga", new FieldRules(false));
			Characters = new GraphQLQueryField("characters", new FieldRules(false));
			Staff = new GraphQLQueryField("staff", new FieldRules(false));
			Studios = new GraphQLQueryField("studios", new FieldRules(false));
		}
	}
}
