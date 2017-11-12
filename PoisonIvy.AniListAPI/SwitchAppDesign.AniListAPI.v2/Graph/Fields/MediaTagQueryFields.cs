using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaTagQueryFields
	{
		public MediaTagQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The id of the tag
		/// </summary>
		public GraphQLQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the tag
		/// </summary>
		public GraphQLQueryField NameQueryField()
		{
			return Name;
		}

		/// <summary>
		/// A general description of the tag
		/// </summary>
		public GraphQLQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// The categories of tags this tag belongs to
		/// </summary>
		public GraphQLQueryField CategoryQueryField()
		{
			return Category;
		}

		/// <summary>
		/// The relevance ranking of the tag out of the 100 for this media
		/// </summary>
		public GraphQLQueryField RankQueryField()
		{
			return Rank;
		}

		/// <summary>
		/// If the tag could be a spoiler for any media
		/// </summary>
		public GraphQLQueryField IsGeneralSpoilerQueryField()
		{
			return IsGeneralSpoiler;
		}

		/// <summary>
		/// If the tag is a spoiler for this media
		/// </summary>
		public GraphQLQueryField IsMediaSpoilerQueryField()
		{
			return IsMediaSpoiler;
		}

		/// <summary>
		/// If the tag is only for adult 18+ media
		/// </summary>
		public GraphQLQueryField IsAdultQueryField()
		{
			return IsAdult;
		}

		private GraphQLQueryField Id { get; set; }
		private GraphQLQueryField Name { get; set; }
		private GraphQLQueryField Description { get; set; }
		private GraphQLQueryField Category { get; set; }
		private GraphQLQueryField Rank { get; set; }
		private GraphQLQueryField IsGeneralSpoiler { get; set; }
		private GraphQLQueryField IsMediaSpoiler { get; set; }
		private GraphQLQueryField IsAdult { get; set; }

		private void InitializeProperties()
		{
			Id = new GraphQLQueryField("id", new FieldRules(false));
			Name = new GraphQLQueryField("name", new FieldRules(false));
			Description = new GraphQLQueryField("description", new FieldRules(false));
			Category = new GraphQLQueryField("category", new FieldRules(false));
			Rank = new GraphQLQueryField("rank", new FieldRules(false));
			IsGeneralSpoiler = new GraphQLQueryField("isGeneralSpoiler", new FieldRules(false));
			IsMediaSpoiler = new GraphQLQueryField("isMediaSpoiler", new FieldRules(false));
			IsAdult = new GraphQLQueryField("isAdult", new FieldRules(false));
		}
	}
}
