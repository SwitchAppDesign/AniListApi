using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaTagQueryFields
	{
		public MediaTagQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the tag
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the tag
		/// </summary>
		public GraphQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// A general description of the tag
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// The categories of tags this tag belongs to
		/// </summary>
		public GraphQueryField CategoryQueryField()
		{
			return Category;
		}

		/// <summary>
		/// The relevance ranking of the tag out of the 100 for this media
		/// </summary>
		public GraphQueryField RankQueryField()
		{
			return Rank;
		}

		/// <summary>
		/// If the tag could be a spoiler for any media
		/// </summary>
		public GraphQueryField IsGeneralSpoilerQueryField()
		{
			return IsGeneralSpoiler;
		}

		/// <summary>
		/// If the tag is a spoiler for this media
		/// </summary>
		public GraphQueryField IsMediaSpoilerQueryField()
		{
			return IsMediaSpoiler;
		}

		/// <summary>
		/// If the tag is only for adult 18+ media
		/// </summary>
		public GraphQueryField IsAdultQueryField()
		{
			return IsAdult;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField Description { get; set; }
		private GraphQueryField Category { get; set; }
		private GraphQueryField Rank { get; set; }
		private GraphQueryField IsGeneralSpoiler { get; set; }
		private GraphQueryField IsMediaSpoiler { get; set; }
		private GraphQueryField IsAdult { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Name = new GraphQueryField("name", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Description = new GraphQueryField("description", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Category = new GraphQueryField("category", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Rank = new GraphQueryField("rank", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsGeneralSpoiler = new GraphQueryField("isGeneralSpoiler", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsMediaSpoiler = new GraphQueryField("isMediaSpoiler", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsAdult = new GraphQueryField("isAdult", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
