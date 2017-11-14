using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class FavouritesQueryFields
	{
		public FavouritesQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		public GraphQueryField AnimeQueryField()
		{
			return Anime;
		}

		public GraphQueryField MangaQueryField()
		{
			return Manga;
		}

		public GraphQueryField CharactersQueryField()
		{
			return Characters;
		}

		public GraphQueryField StaffQueryField()
		{
			return Staff;
		}

		public GraphQueryField StudiosQueryField()
		{
			return Studios;
		}

		private GraphQueryField Anime { get; set; }
		private GraphQueryField Manga { get; set; }
		private GraphQueryField Characters { get; set; }
		private GraphQueryField Staff { get; set; }
		private GraphQueryField Studios { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Anime = new GraphQueryField("anime", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Manga = new GraphQueryField("manga", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Characters = new GraphQueryField("characters", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Staff = new GraphQueryField("staff", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
			Studios = new GraphQueryField("studios", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.User }));
		}
	}
}
