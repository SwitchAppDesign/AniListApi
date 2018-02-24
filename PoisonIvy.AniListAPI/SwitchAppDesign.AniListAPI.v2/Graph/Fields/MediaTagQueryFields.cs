using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available character query fields.
    /// </summary>
	public class MediaTagQueryFields
	{
		internal MediaTagQueryFields(AniListQueryType queryType)
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
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			Name = new GraphQueryField("name", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			Description = new GraphQueryField("description", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			Category = new GraphQueryField("category", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			Rank = new GraphQueryField("rank", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			IsGeneralSpoiler = new GraphQueryField("isGeneralSpoiler", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			IsMediaSpoiler = new GraphQueryField("isMediaSpoiler", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
			IsAdult = new GraphQueryField("isAdult", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media, AniListQueryType.Page }));
		}
	}
}
